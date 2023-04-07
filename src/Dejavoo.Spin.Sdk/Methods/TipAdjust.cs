using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Methods.Models;
using JetBrains.Annotations;

namespace Dejavoo.Spin.Sdk.Methods
{
    public sealed class TipAdjust : OperationBase<TipAdjustResponse>
    {
        public TipAdjust(double amount, string last4, PaymentType paymentType)
        {
            Amount = amount;
            Last4 = last4;
            PaymentType = paymentType;
        }

        public double Amount { get; }

        public string Last4 { get; }

        public PaymentType PaymentType { get; }

        public override Task<TipAdjustResponse> ExecuteAsync(IOperationExecutor executor) => executor.Execute(this);
    }

    public sealed class TipAdjustResponse : IGenericResponse
    {
        public string AuthCode { get; [UsedImplicitly] set; }

        public string ReferenceId { get; [UsedImplicitly] set; }
    }
}
