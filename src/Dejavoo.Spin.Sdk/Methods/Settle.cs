using System.Threading.Tasks;

namespace Dejavoo.Spin.Sdk.Methods
{
    public sealed class Settle : OperationBase<SettleResponse>
    {
        public override Task<SettleResponse> ExecuteAsync(IOperationExecutor executor) => executor.Execute(this);
    }

    public sealed class SettleResponse
    {
    }
}
