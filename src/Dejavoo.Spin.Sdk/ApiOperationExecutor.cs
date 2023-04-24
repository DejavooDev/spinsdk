using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Client.Api;
using Dejavoo.Spin.Sdk.Client.Client;
using Dejavoo.Spin.Sdk.Client.Model;
using Dejavoo.Spin.Sdk.Methods;
using Dejavoo.Spin.Sdk.Options;
using Dejavoo.Spin.Sdk.Options.Definitions;
using Mapster;
using Newtonsoft.Json;
using Polly;
using Polly.Retry;
using RestSharp;
using Void = Dejavoo.Spin.Sdk.Methods.Void;

namespace Dejavoo.Spin.Sdk
{
    internal sealed class ApiOperationExecutor : IOperationExecutor
    {
        private static readonly ConcurrentDictionary<Type, IRetryPolicy> Policies = new();

        private const int MaxRetryCount = 3;

        private readonly IRegisterApi _api;

        private readonly string _authKey;
        private readonly string _tpn;

        private readonly int _apiTimeoutSeconds;

        private readonly ConcurrentDictionary<string, object> _requestsInFlights;

        private ApiOperationExecutor(IRegisterApi api, string authKey, string tpn, int apiTimeoutSeconds)
        {
            _api = api;
            _authKey = authKey;
            _tpn = tpn;
            _apiTimeoutSeconds = apiTimeoutSeconds;

            _requestsInFlights = new ConcurrentDictionary<string, object>();
        }

        public async Task<SaleResponse> Execute(Sale sale)
        {
            var refId = ReferenceIdFactory();

            var saleRequestContract = new SaleRequestContract(
                sale.Amount,
                paymentType: (SaleRequestContract.PaymentTypeEnum)sale.PaymentType,
                referenceId: refId,
                tpn: _tpn,
                authkey: _authKey,
                sPInProxyTimeout: _apiTimeoutSeconds);

            BasePaymentResponseContract response = await ResilientExecuteAsync(
                () => _api.RegisterSaleAsync(saleRequestContract),
                refId);

            return response.Adapt<SaleResponse>();
        }

        public async Task<VoidResponse> Execute(Void @void)
        {
            var refId = ReferenceIdFactory();

            var voidRequestContract = new VoidRequestContract(
                @void.Amount,
                paymentType: (VoidRequestContract.PaymentTypeEnum)@void.PaymentType,
                referenceId: refId,
                tpn: _tpn,
                authkey: _authKey,
                sPInProxyTimeout: _apiTimeoutSeconds);

            BasePaymentResponseContract response = await ResilientExecuteAsync(
                () => _api.RegisterVoidAsync(voidRequestContract),
                refId);

            return response.Adapt<VoidResponse>();
        }

        public async Task<SettleResponse> Execute(Settle settle)
        {
            var refId = ReferenceIdFactory();

            var settleRequestContract = new SettleRequestContract(
                referenceId: refId,
                tpn: _tpn,
                authkey: _authKey,
                sPInProxyTimeout: _apiTimeoutSeconds);

            SettleResponseContract response = await ResilientExecuteAsync(
                () => _api.RegisterSettleAsync(settleRequestContract),
                refId);

            return response.Adapt<SettleResponse>();
        }

        public async Task<ReturnResponse> Execute(Return @return)
        {
            var refId = ReferenceIdFactory();

            var returnRequestContract = new ReturnRequestContract(
                @return.Amount,
                paymentType: (ReturnRequestContract.PaymentTypeEnum)@return.PaymentType,
                referenceId: refId,
                tpn: _tpn,
                authkey: _authKey,
                sPInProxyTimeout: _apiTimeoutSeconds);

            BasePaymentResponseContract response = await ResilientExecuteAsync(
                () => _api.RegisterReturnAsync(returnRequestContract),
                refId);

            return response.Adapt<ReturnResponse>();
        }

        public async Task<TipAdjustResponse> Execute(TipAdjust tipAdjust)
        {
            var refId = ReferenceIdFactory();

            var tipAdjustRequestContract = new TipAdjustRequestContract(
                amount: tipAdjust.Amount,
                cardLast4: tipAdjust.Last4,
                paymentType: (TipAdjustRequestContract.PaymentTypeEnum)tipAdjust.PaymentType,
                referenceId: refId,
                tpn: _tpn,
                authkey: _authKey,
                sPInProxyTimeout: _apiTimeoutSeconds);

            BasePaymentResponseContract response = await ResilientExecuteAsync(
                () => _api.RegisterTipAdjustAsync(tipAdjustRequestContract),
                refId);

            return response.Adapt<TipAdjustResponse>();
        }

        public async Task<StatusResponse> Execute(Status status)
        {
            var statusRequestContract = new StatusRequestContract(
                paymentType: (StatusRequestContract.PaymentTypeEnum)status.PaymentType,
                referenceId: status.ReferenceId,
                tpn: _tpn,
                authkey: _authKey,
                sPInProxyTimeout: _apiTimeoutSeconds);

            BasePaymentResponseContract response = await ResilientExecuteAsync(
                () => _api.RegisterStatusAsync(statusRequestContract),
                status.ReferenceId);

            return response.Adapt<StatusResponse>();
        }

        private async Task<T> ResilientExecuteAsync<T>(Func<Task<T>> f, string refId)
        {
            Func<Context, Task<T>> TrackedExecuteAsync(Func<Task<T>> func, string referenceId)
                => _ => _requestsInFlights.TryRemove(referenceId, out var state)
                    ? Task.FromResult((T)state)
                    : func();

            PolicyResult<T> capture = await GetOrCreateRetryPolicy<T>().ExecuteAndCaptureAsync(
                TrackedExecuteAsync(f, refId),
                new Context(
                    refId,
                    new Dictionary<string, object>
                    {
                        { nameof(refId), refId },
                    }));

            if (capture.Outcome == OutcomeType.Failure)
            {
                throw capture.FinalException;
            }

            return capture.Result;
        }

        public static IOperationExecutor Create(IOptionsAccessor optionsAccessor)
        {
            T GetOption<T>(bool required = true) where T : IOption
            {
                var exists = optionsAccessor.TryGetOption(out T o);

                return required && !exists ? throw ThrowHelper.ThrowMissingRequiredConfiguration(typeof(T).Name) : o;
            }

            ApiAccessOptions apiAccessOptions = GetOption<ApiAccessOptions>();
            AuthenticationOptions authenticationOptions = GetOption<AuthenticationOptions>();
            
            var config = Configuration.Default;
            {
                config.BasePath = apiAccessOptions.BaseUrl;
            }

            var registerApi = new RegisterApi(config);
            {
                registerApi.ExceptionFactory = ExceptionFactory;
            }
            
            TimeoutOptions timeoutOptions = GetOption<TimeoutOptions>(false);
            var timeoutSeconds = timeoutOptions == null ? 100 : (int)timeoutOptions.Timeout.TotalSeconds;

            return new ApiOperationExecutor(
                registerApi,
                authenticationOptions.AuthKey,
                authenticationOptions.Tpn,
                timeoutSeconds);
        }

        private static readonly Func<string> ReferenceIdFactory = () => Guid.NewGuid().ToString("N");

        private static Exception ExceptionFactory(string apiMethod, RestResponse response)
        {
            var partialResponse = JsonConvert.DeserializeObject<Partial<dynamic>>(response.Content);

            GeneralResponse generalResponse = partialResponse.GeneralResponse;
            if (generalResponse.StatusCode < 1000)
            {
                return null;
            }

            return apiMethod switch
            {
                "RegisterSale" => ThrowHelper.ThrowByCode(partialResponse.GeneralResponse.StatusCode),
                "RegisterVoid" => ThrowHelper.ThrowByCode(partialResponse.GeneralResponse.StatusCode),
                "RegisterTipAdjust" => ThrowHelper.ThrowByCode(partialResponse.GeneralResponse.StatusCode),
                "RegisterReturn" => ThrowHelper.ThrowByCode(partialResponse.GeneralResponse.StatusCode),
                "RegisterStatus" => ThrowHelper.ThrowByCode(partialResponse.GeneralResponse.StatusCode),
                _ => throw new ArgumentOutOfRangeException(nameof(apiMethod)),
            };
        }

        private IAsyncPolicy<T> GetOrCreateRetryPolicy<T>() =>
            (IAsyncPolicy<T>)Policies.GetOrAdd(
                typeof(T),
                _ => Policy<T>
                    .Handle<ExecutorException>(exception => exception.IsRecoverable)
                    .WaitAndRetryAsync(
                        MaxRetryCount,
                        attempt => TimeSpan.FromSeconds(Math.Pow(2, attempt)),
                        async (exception, span, context) =>
                        {
                            Debug.WriteLine($"Exception occured, retrying {exception} {span}");
                            {
                                var statusRequest = new StatusRequestContract(
                                    paymentType: StatusRequestContract.PaymentTypeEnum.Card,
                                    referenceId: context.OperationKey,
                                    tpn: _tpn,
                                    authkey: _authKey,
                                    sPInProxyTimeout: _apiTimeoutSeconds);

                                BasePaymentResponseContract response = await _api.RegisterStatusAsync(statusRequest);
                                _requestsInFlights.AddOrUpdate(
                                    context.OperationKey,
                                    _ => response,
                                    (_, _) => response);
                            }
                        }));
    }
}
