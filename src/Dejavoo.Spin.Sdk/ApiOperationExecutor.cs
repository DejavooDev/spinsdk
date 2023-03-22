using System;
using System.Collections.Concurrent;
using System.Net;
using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Client.Api;
using Dejavoo.Spin.Sdk.Client.Client;
using Dejavoo.Spin.Sdk.Client.Model;
using Dejavoo.Spin.Sdk.Methods;
using Polly;
using RestSharp;

namespace Dejavoo.Spin.Sdk
{
    internal sealed class ApiOperationExecutor : IOperationExecutor
    {
        private readonly IRegisterApi _api;

        private readonly string _authKey;
        private readonly string _tpn;

        private readonly IAsyncPolicy _retryPolicy;

        private readonly ConcurrentDictionary<string, ConcurrentQueue<Guid>> _operationsTracker = new();

        private ApiOperationExecutor(IRegisterApi api, string authKey, string tpn)
        {
            _api = api;
            _authKey = authKey;
            _tpn = tpn;

            _retryPolicy = CreateRetryPolicy();
        }

        public async Task<SaleResponse> Execute(Sale sale)
        {
            var saleRequestContract = new SaleRequestContract(
                sale.Amount,
                paymentType: SaleRequestContract.PaymentTypeEnum.Card,
                referenceId: ReferenceIdFactory(),
                tpn: _tpn,
                authkey: _authKey);

            BasePaymentResponseContract response = await ResilientExecuteAsync(() => _api.RegisterSaleAsync(saleRequestContract));

            return new SaleResponse();
        }

        private async Task<T> ResilientExecuteAsync<T>(Func<Task<T>> f)
        {
            PolicyResult<T> capture = await _retryPolicy.ExecuteAndCaptureAsync(f);

            return capture.Result;
        }

        public static IOperationExecutor Create(string baseUri, string authKey, string tpn)
        {
            var config = Configuration.Default;
            {
                config.BasePath = baseUri;
            }

            var registerApi = new RegisterApi(config);
            {
                registerApi.ExceptionFactory = ExceptionFactory;
            }

            return new ApiOperationExecutor(registerApi, authKey, tpn);
        }

        private static readonly Func<string> ReferenceIdFactory = () => Guid.NewGuid().ToString("N");

        private static Exception ExceptionFactory(string apiMethod, RestResponse response)
        {
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                ThrowHelper.ThrowUnauthorized();
            }

            return apiMethod switch
            {
                "RegisterSale" => null,
                _ => throw new ArgumentOutOfRangeException(nameof(apiMethod)),
            };
        }

        private static IAsyncPolicy CreateRetryPolicy() =>
            Policy.Handle<ExecutorException>(exception => exception.IsRecoverable)
                .WaitAndRetryAsync(
                    5,
                    attempt => TimeSpan.FromSeconds(1),
                    (exception, span) => { });
    }
}
