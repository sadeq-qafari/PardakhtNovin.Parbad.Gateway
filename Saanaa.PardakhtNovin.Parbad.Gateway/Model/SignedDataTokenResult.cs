using System;

namespace Saanaa.PardakhtNovin.Parbad.Gateway.Model
{
    [Serializable]
    public class SignedDataTokenResult
    {
        public string Result { get; set; }
        public long ExpirationDate { get; set; }
        public string Token { get; set; }
        public string ChannelId { get; set; }
        public string UserId { get; set; }
    }
}
