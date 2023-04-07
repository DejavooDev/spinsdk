using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Dejavoo.Spin.Sdk.Methods
{
    public sealed class Settle : OperationBase<SettleResponse>
    {
        public override Task<SettleResponse> ExecuteAsync(IOperationExecutor executor) => executor.Execute(this);
    }

    public sealed class SettleResponse : IGenericResponse
    {
        public string AuthCode { get; [UsedImplicitly] set; }
        
        public string ReferenceId { get; [UsedImplicitly] set; }
    }
}
