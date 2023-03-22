using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Methods;

namespace Dejavoo.Spin.Sdk
{
    public interface IOperationExecutor
    {
        Task<SaleResponse> Execute(Sale sale);
    }
}
