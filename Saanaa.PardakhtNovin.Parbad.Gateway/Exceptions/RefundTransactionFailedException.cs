using System;
using Parbad.Options;

namespace Saanaa.PardakhtNovin.Parbad.Gateway.Exceptions
{
    public class RefundTransactionFailedException : Exception
    {
        public RefundTransactionFailedException(MessagesOptions messagesOptions) : base(messagesOptions.UnexpectedErrorText)
        { }
    }
}
