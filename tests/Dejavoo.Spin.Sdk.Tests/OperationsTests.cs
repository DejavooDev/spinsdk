using System.Diagnostics;
using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Methods;
using Dejavoo.Spin.Sdk.Methods.Models;
using Xunit;

namespace Dejavoo.Spin.Sdk.UnitTests
{
    public sealed class OperationsTests
    {
        [Fact]
        public async Task PlainSale_ShouldSucceed()
        {
            IOperationExecutor executor = CreateTarget();

            IOperation<SaleResponse> operation = Operations.Sale(1.0f, PaymentType.Credit);

            SaleResponse response = await operation.ExecuteAsync(executor);
            
            Debug.WriteLine(response);
        }

        [Fact]
        public async Task PlainVoid_ShouldSucceed()
        {
            IOperationExecutor executor = CreateTarget();

            IOperation<VoidResponse> operation = Operations.Void(1.0f, PaymentType.Credit);

            VoidResponse response = await operation.ExecuteAsync(executor);

            Debug.WriteLine(response);
        }
        
        [Fact]
        public async Task PlainTipAdjust_ShouldSucceed()
        {
            IOperationExecutor executor = CreateTarget();

            IOperation<TipAdjustResponse> operation = Operations.TipAdjust(1.0f, "8236", PaymentType.Credit);

            TipAdjustResponse response = await operation.ExecuteAsync(executor);

            Debug.WriteLine(response);
        }
        
        [Fact]
        public async Task PlainReturn_ShouldSucceed()
        {
            IOperationExecutor executor = CreateTarget();

            IOperation<ReturnResponse> operation = Operations.Return(1.0f, PaymentType.Credit);

            ReturnResponse response = await operation.ExecuteAsync(executor);

            Debug.WriteLine(response);
        }

        private IOperationExecutor CreateTarget() => Spin.V2.CreateExecutor("your_tpn_id", "your_api_key");
    }
}