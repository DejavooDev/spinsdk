using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Methods.Models;
using JetBrains.Annotations;

namespace Dejavoo.Spin.Sdk.Methods
{
    public sealed class Void : OperationBase<VoidResponse>
    {
        public Void(double amount, PaymentType paymentType)
        {
            Amount = amount;
            PaymentType = paymentType;
        }

        public double Amount { get; }

        public PaymentType PaymentType { get; }

        public override Task<VoidResponse> ExecuteAsync(IOperationExecutor executor) => executor.Execute(this);
    }

    public sealed class VoidResponse : IGenericResponse
    {
        public string AuthCode { get; [UsedImplicitly] set; }
        
        public string ReferenceId { get; [UsedImplicitly] set; }
    }
}
