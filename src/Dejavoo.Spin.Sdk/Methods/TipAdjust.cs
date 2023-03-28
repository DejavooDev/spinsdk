using System.Threading.Tasks;

namespace Dejavoo.Spin.Sdk.Methods
{
    public sealed class TipAdjust : OperationBase<TipAdjustResponse>
    {
        public TipAdjust(double amount, string last4)
        {
            Amount = amount;
            Last4 = last4;
        }

        public double Amount { get; }

        public string Last4 { get; }

        public override Task<TipAdjustResponse> ExecuteAsync(IOperationExecutor executor) => executor.Execute(this);
    }

    public sealed class TipAdjustResponse
    {
    }
}
