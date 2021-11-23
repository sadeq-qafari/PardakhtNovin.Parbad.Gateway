using System;
using Ardalis.GuardClauses;
using Newtonsoft.Json;

namespace Saanaa.PardakhtNovin.Parbad.Gateway.Model
{
    [Serializable]
    public class WSContext
    {
        public WSContext(string username, string password)
        {
            Guard.Against.NullOrEmpty(username, nameof(username));
            Guard.Against.NullOrEmpty(password, nameof(password));

            UserId = username;
            Password = password;
        }
        [JsonProperty(nameof(UserId))]
        public string UserId { get; private set; }
        [JsonProperty(nameof(Password))]
        public string Password { get; private set; }
    }
}
