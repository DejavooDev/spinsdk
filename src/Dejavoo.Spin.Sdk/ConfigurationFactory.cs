using System;

namespace Dejavoo.Spin.Sdk
{
    internal sealed class ConfigurationFactory
    {
        public static T Configure<T>(Action<T> configure = null, T def = default)
            where T : class, new()
        {
            T input = def ?? new T();
            {
                configure?.Invoke(input);
            }

            return input;
        }
    }
}
