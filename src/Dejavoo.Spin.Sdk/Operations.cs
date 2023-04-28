using Dejavoo.Spin.Sdk.Methods;
using Dejavoo.Spin.Sdk.Methods.Models;

namespace Dejavoo.Spin.Sdk
{
    public static class Operations
    {
        public static IOperation<SaleResponse> Sale(double amount, PaymentType paymentType) => new Sale(amount, paymentType);

        public static IOperation<ReturnResponse> Return(double amount, PaymentType paymentType) => new Return(amount, paymentType);

        public static IOperation<SettleResponse> Settle() => new Settle();

        public static IOperation<TipAdjustResponse> TipAdjust(double amount, string last4, PaymentType paymentType) =>
            new TipAdjust(amount, last4, paymentType);

        public static IOperation<VoidResponse> Void(double amount, PaymentType paymentType) => new Void(amount, paymentType);

        public static IOperation<StatusResponse> Status(string referenceId, PaymentType paymentType) =>
            new Status(paymentType, referenceId);
    }
}
