using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Methods.Models;
using JetBrains.Annotations;

namespace Dejavoo.Spin.Sdk.Methods
{
    public sealed class Return : OperationBase<ReturnResponse>
    {
        public Return(double amount, PaymentType paymentType)
        {
            Amount = amount;
            PaymentType = paymentType;
        }

        public double Amount { get; }

        public PaymentType PaymentType { get; }

        public override Task<ReturnResponse> ExecuteAsync(IOperationExecutor executor) => executor.Execute(this);
    }

    public sealed class ReturnResponse : IGenericResponse
    {
        public string AuthCode { get; [UsedImplicitly] set; }

        public string ReferenceId { get; [UsedImplicitly] set; }
    }
}
