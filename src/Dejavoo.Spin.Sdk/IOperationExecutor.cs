using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Methods;

namespace Dejavoo.Spin.Sdk
{
    public interface IOperationExecutor
    {
        Task<SaleResponse> Execute(Sale sale);

        Task<VoidResponse> Execute(Void @void);

        Task<SettleResponse> Execute(Settle settle);
        
        Task<ReturnResponse> Execute(Return @return);
        
        Task<TipAdjustResponse> Execute(TipAdjust tipAdjust);
    }
}
