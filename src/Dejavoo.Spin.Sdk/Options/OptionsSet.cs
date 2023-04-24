using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Dejavoo.Spin.Sdk.Options
{
    public sealed class OptionsSet : IOptionsAccessor
    {
        private readonly IDictionary<Type, IOption> _options = new Dictionary<Type, IOption>();

        [MethodImpl(MethodImplOptions.Synchronized)]
        public T Option<T>(Action<T> configure)
            where T : IOption, new()
        {
            T option;

            if (_options.ContainsKey(typeof(T)))
            {
                option = (T)_options[typeof(T)];
                
                configure(option);
            }
            else
            {
                option = new T();
                
                configure(option);

                ValidationResult validationResult = option.Validate();
                if (!validationResult.Success)
                {
                    throw new InvalidOperationException(
                        $"Validation Failure for {typeof(T).Name}: {validationResult.ErrorMessage}");
                }

                _options[typeof(T)] = option;
            }

            return option;
        }

        public bool TryGetOption<T>(out T option)
            where T : IOption
        {
            if (_options.TryGetValue(typeof(T), out IOption o))
            {
                option = (T)o;
                return true;
            }

            option = default;
            return false;
        }
    }
}
