using System;
using Parbad;
using Parbad.GatewayBuilders;
using Parbad.InvoiceBuilder;

namespace Saanaa.PardakhtNovin.Parbad.Gateway
{
    public static class PardakhtNovinGatewayBuilderExtensions
    {
        public static IGatewayConfigurationBuilder<PardakhtNovinGateway> AddPardakhtNovin(this IGatewayBuilder builder)
        {
            return builder.AddGateway<PardakhtNovinGateway>();
        }

        public static IGatewayConfigurationBuilder<PardakhtNovinGateway> WithAccounts(this IGatewayConfigurationBuilder<PardakhtNovinGateway> builder, Action<IGatewayAccountBuilder<PardakhtNovinGatewayAccount>> configureAccounts)
        {
            return builder.WithAccounts(configureAccounts);
        }

        public static IInvoiceBuilder UsePardakhtNovin(this IInvoiceBuilder builder)
        {
            return builder.SetGateway(PardakhtNovinGateway.Name);
        }
    }
}
