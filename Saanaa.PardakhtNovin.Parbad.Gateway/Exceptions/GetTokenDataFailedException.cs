using System;
using Parbad.Options;

namespace Saanaa.PardakhtNovin.Parbad.Gateway.Exceptions
{
    public class GetTokenDataFailedException : Exception
    {
        public GetTokenDataFailedException(MessagesOptions _messagesOptions) : base(_messagesOptions.InvalidDataReceivedFromGateway)
        { }
    }
}
