using System;

namespace Dejavoo.Spin.Sdk.Options.Definitions
{
    public sealed class TimeoutOptions : IOption
    {
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(100);

        public ValidationResult Validate()
        {
            if (Timeout == default || Timeout <= TimeSpan.Zero)
            {
                return ValidationResult.Fail("Timeout cannot be 0, negative or non-specified");
            }

            return ValidationResult.Ok;
        }
    }
}
