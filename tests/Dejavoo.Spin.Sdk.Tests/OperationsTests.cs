using System.Diagnostics;
using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Methods;
using Xunit;

namespace Dejavoo.Spin.Sdk.UnitTests
{
    public sealed class OperationsTests
    {
        [Fact]
        public async Task PlainSale_ShouldSucceed()
        {
            IOperationExecutor executor = Spin.V2Test.CreateExecutor("your_tpn_id", "your_api_key");

            IOperation<SaleResponse> operation = Operations.Sale(1.0f);

            SaleResponse response = await operation.ExecuteAsync(executor);
            
            Debug.WriteLine(response);
        }
    }
}