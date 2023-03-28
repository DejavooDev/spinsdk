using System.Threading.Tasks;

namespace Dejavoo.Spin.Sdk.Methods
{
    public sealed class Return : OperationBase<ReturnResponse>
    {
        public Return(double amount)
        {
            Amount = amount;
        }

        public double Amount { get; }

        public override Task<ReturnResponse> ExecuteAsync(IOperationExecutor executor) => executor.Execute(this);
    }

    public sealed class ReturnResponse
    {
    }
}
