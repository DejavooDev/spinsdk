namespace Dejavoo.Spin.Sdk.Options
{
    public sealed class ValidationResult
    {
        public static readonly ValidationResult Ok = new() { Success = true };

        public static ValidationResult Fail(string reason) =>
            new()
            {
                ErrorMessage = reason,
            };

        private ValidationResult()
        {
        }

        public bool Success { get; private set; }

        public string ErrorMessage { get; private set; }
    }
}
