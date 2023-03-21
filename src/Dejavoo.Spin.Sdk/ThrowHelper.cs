using System;
using JetBrains.Annotations;

namespace Dejavoo.Spin.Sdk
{
    public class ExecutorException : Exception
    {
        internal ExecutorException(string message, bool isRecoverable)
            : base(message)
        {
            IsRecoverable = isRecoverable;
        }

        public bool IsRecoverable { get; }
    }

    public enum ErrorCode
    {
        Unauthorized = 401,
    }

    public static class ThrowHelper
    {
        [ContractAnnotation("=> halt")]
        internal static void ThrowUnauthorized() => throw new Unauthorized();

        private sealed class Unauthorized : ExecutorException
        {
            public Unauthorized()
                : base(ErrorCode.Unauthorized, false)
            {
            }
        }
    }
}
