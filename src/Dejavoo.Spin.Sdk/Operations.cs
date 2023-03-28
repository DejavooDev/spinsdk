using Dejavoo.Spin.Sdk.Methods;

namespace Dejavoo.Spin.Sdk
{
    public static class Operations
    {
        public static IOperation<SaleResponse> Sale(double amount) => new Sale(amount);

        public static IOperation<ReturnResponse> Return(double amount) => new Return(amount);

        public static IOperation<SettleResponse> Settle() => new Settle();

        public static IOperation<TipAdjustResponse> TipAdjust(double amount, string last4) => new TipAdjust(amount, last4);

        public static IOperation<VoidResponse> Void(double amount) => new Void(amount);
    }
}
