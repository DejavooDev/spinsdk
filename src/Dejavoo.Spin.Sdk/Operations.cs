using Dejavoo.Spin.Sdk.Methods;

namespace Dejavoo.Spin.Sdk
{
    public static class Operations
    {
        public static IOperation<Sale.SaleResponse> Sale(double amount) => new Sale(amount);
    }
}