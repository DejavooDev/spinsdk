using System.Threading.Tasks;

namespace Dejavoo.Spin.Sdk.Methods
{
    public sealed class Sale : OperationBase<SaleResponse>
    {
        public Sale(double amount)
        {
            Amount = amount;
        }

        public double Amount { get; }

        public override Task<SaleResponse> ExecuteAsync(IOperationExecutor executor) => executor.Execute(this);
    }
    
    public sealed class SaleResponse
    {
    }
}
