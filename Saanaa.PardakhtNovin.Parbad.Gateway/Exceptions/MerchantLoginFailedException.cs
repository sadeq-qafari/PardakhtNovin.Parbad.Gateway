using System;
using Parbad.Options;

namespace Saanaa.PardakhtNovin.Parbad.Gateway.Exceptions
{
    public class MerchantLoginFailedException : Exception
    {
        public MerchantLoginFailedException(MessagesOptions _messagesOptions) : base(_messagesOptions.UnexpectedErrorText)
        { }
    }
}
