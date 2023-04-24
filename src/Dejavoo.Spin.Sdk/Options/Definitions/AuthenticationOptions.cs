namespace Dejavoo.Spin.Sdk.Options.Definitions
{
    internal sealed class AuthenticationOptions : IOption
    {
        public string Tpn { get; set; }
        
        public string AuthKey { get; set; }
        
        public ValidationResult Validate()
        {
            if (string.IsNullOrEmpty(Tpn) || string.IsNullOrEmpty(AuthKey))
            {
                return ValidationResult.Fail("Must define both: Tpn & AuthKey");
            }
            
            return ValidationResult.Ok;
        }
    }
}