using System;
using Parbad.Options;

namespace Saanaa.PardakhtNovin.Parbad.Gateway.Exceptions
{
    public class TransactionCanceledException : Exception
    {
        public TransactionCanceledException(MessagesOptions messagesOptions) : base(messagesOptions.PaymentFailed)
        { }
    }
}
