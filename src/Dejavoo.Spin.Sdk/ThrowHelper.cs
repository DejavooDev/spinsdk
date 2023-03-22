using System;
using JetBrains.Annotations;

namespace Dejavoo.Spin.Sdk
{
    public class ExecutorException : Exception
    {
        internal ExecutorException(ErrorCode code, bool isRecoverable)
        {
            Code = code;
            IsRecoverable = isRecoverable;
        }

        public ErrorCode Code { get; }
        
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
