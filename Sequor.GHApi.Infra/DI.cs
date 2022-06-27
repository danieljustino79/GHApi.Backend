using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sequor.GHApi.Infra.Integrations;
using Sequor.GHApi.Infra.Integrations.Interfaces;

namespace Sequor.GHApi.Infra
{
    public static class DI
    {
        public static void AddInfraDI(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<IGHApiIntegration, GHApiIntegration>();
        }
    }
}
