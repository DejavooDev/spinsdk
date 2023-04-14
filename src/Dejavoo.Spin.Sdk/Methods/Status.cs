using System.Threading.Tasks;
using Dejavoo.Spin.Sdk.Methods.Models;
using JetBrains.Annotations;

namespace Dejavoo.Spin.Sdk.Methods
{
    public class Status : OperationBase<StatusResponse>
    {
        public Status(PaymentType paymentType, string referenceId)
        {
            PaymentType = paymentType;
            ReferenceId = referenceId;
        }

        public PaymentType PaymentType { get; }

        public string ReferenceId { get; }

        public override Task<StatusResponse> ExecuteAsync(IOperationExecutor executor) => executor.Execute(this);
    }

    public sealed class StatusResponse : IGenericResponse
    {
        public string AuthCode { get; [UsedImplicitly] set; }

        public string ReferenceId { get; [UsedImplicitly] set; }
    }
}
