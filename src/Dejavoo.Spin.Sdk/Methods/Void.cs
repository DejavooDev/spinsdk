using System.Threading.Tasks;

namespace Dejavoo.Spin.Sdk.Methods
{
    public sealed class Void : OperationBase<VoidResponse>
    {
        public Void(double amount)
        {
            Amount = amount;
        }

        public double Amount { get; }

        public override Task<VoidResponse> ExecuteAsync(IOperationExecutor executor) => executor.Execute(this);
    }

    public sealed class VoidResponse
    {
    }
}
