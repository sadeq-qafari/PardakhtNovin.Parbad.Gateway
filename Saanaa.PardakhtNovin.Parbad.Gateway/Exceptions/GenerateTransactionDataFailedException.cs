using System;
using Parbad.Options;

namespace Saanaa.PardakhtNovin.Parbad.Gateway.Exceptions
{
    public class GenerateTransactionDataFailedException : Exception
    {
        public GenerateTransactionDataFailedException(MessagesOptions messagesOptions) : base(messagesOptions.InvalidDataReceivedFromGateway)
        { }
    }
}
