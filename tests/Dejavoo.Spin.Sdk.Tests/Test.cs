using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Methods;

namespace Dejavoo.Spin.Sdk.UnitTests
{
    public class Test
    {
        public async Task Test()
        {
            IOperationExecutor executor = Spin.V3.CreateExecutor();

            IOperation<SaleResponse> operation = Operations.Sale(100.0f);

            SaleResponse response = await operation.ExecuteAsync(executor);
        }
    }
}