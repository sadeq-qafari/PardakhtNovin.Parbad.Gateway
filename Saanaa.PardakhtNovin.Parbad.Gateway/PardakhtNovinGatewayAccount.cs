using Parbad.Abstraction;

namespace Saanaa.PardakhtNovin.Parbad.Gateway
{
    public class PardakhtNovinGatewayAccount : GatewayAccount
    {
        public long TerminalId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
