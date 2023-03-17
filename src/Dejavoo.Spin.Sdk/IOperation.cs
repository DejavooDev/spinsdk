using System.Threading.Tasks;

namespace Dejavoo.Spin.Sdk
{
    public interface IOperation<TResponse>
    {
        Task<TResponse> ExecuteAsync(IOperationExecutor executor);
    }
}
