using System;
using System.Collections.Generic;

namespace Dejavoo.Spin.Sdk
{
    public sealed class ExecutorConfigurationException : Exception
    {
        public ExecutorConfigurationException(string message)
            : base(message)
        {
        }
    }
    
    public sealed class ExecutorException : Exception
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
        // Terminal Errors
        Busy = 1000,
        NotFound = 1001,
        NotImplemented = 1002,
        NotSupported = 1003,
        NotAllowed = 1004,
        LowBattery = 1005,
        InternalError = 1006,
        FormatError = 1007,
        WrongPaymentOrTransactionType = 1008,
        AuthenticationFailed = 1009,
        MissingReferenceId = 1010,
        DuplicateReferenceId = 1011,
        Canceled = 1012,
        BadRequest = 1013,
        CommunicationError = 1014,
        Declined = 1015,
        PaymentTypeMismatch = 1016,
        IncorrectMerchant = 1017,
        PinPadError = 1018,
        NoDebitKeys = 1019,
        NoOpenBatch = 1020,
        PendingSnfTran = 1021,
        UntippedTran = 1022,
        OpenTab = 1023,
        KeyDeclined = 1024,
        MissingPaymentApp = 1025,
        // Spin Errors
        NotConnected = 2001,
        NoAuthKey = 2002,
        RegisterNotFound = 2003,
        RouteNotFound = 2004,
        ActiveRouteNotFound = 2005,
        NotParseable = 2006,
        Timeout = 2007,
        TerminalInUse = 2008,
        TransactionNotFound = 2009,
        SpinCommunicationError = 2010,
        InvalidRequest = 2201,
    }

    public static class ThrowHelper
    {
        private static readonly ISet<int> RecoverableCodes = new HashSet<int>
        {
            (int)ErrorCode.Busy,
            (int)ErrorCode.InternalError,
            (int)ErrorCode.CommunicationError,
            (int)ErrorCode.PinPadError,
            (int)ErrorCode.NotConnected,
            (int)ErrorCode.Timeout,
            (int)ErrorCode.TerminalInUse,
            (int)ErrorCode.SpinCommunicationError,
        };

        internal static ExecutorException ThrowByCode(int code)
        {
            if (!Enum.IsDefined(typeof(ErrorCode), code))
            {
                throw new InvalidOperationException($"No ErrorCode defined for {code}");
            }

            return new ExecutorException((ErrorCode)code, RecoverableCodes.Contains(code));
        }

        internal static Exception ThrowMissingRequiredConfiguration(string reason) => 
            new ExecutorConfigurationException($"Missing required configuration {reason}");
    }
}
