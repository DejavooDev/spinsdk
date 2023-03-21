using System.Threading.Tasks;

namespace Dejavoo.Spin.Sdk
{
    public abstract class OperationBase<TResponse> : IOperation<TResponse>
    {
        public abstract Task<TResponse> ExecuteAsync(IOperationExecutor executor);
    }
}
