using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sequor.GHApi.Application;
using Sequor.GHApi.Infra;

namespace Sequor.GHApi.CrossCutting.IoC
{
    public static class DI
    {
        public static void AddCrossCuttingDI(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddInfraDI(configuration);
            services.AddApplicationDI();
        }
    }
}
