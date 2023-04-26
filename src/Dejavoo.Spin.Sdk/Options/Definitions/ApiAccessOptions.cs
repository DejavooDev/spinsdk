namespace Dejavoo.Spin.Sdk.Options.Definitions
{
    internal sealed class ApiAccessOptions : IOption
    {
        public string BaseUrl { get; set; }
        
        public ValidationResult Validate()
        {
            if (string.IsNullOrEmpty(BaseUrl))
            {
                return ValidationResult.Fail("Api url must be defined");
            }

            return ValidationResult.Ok;
        }
    }
}