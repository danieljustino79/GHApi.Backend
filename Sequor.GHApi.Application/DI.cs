using Microsoft.Extensions.DependencyInjection;
using Sequor.GHApi.Application.Services;
using Sequor.GHApi.Application.Services.Interfaces;

namespace Sequor.GHApi.Application
{
    public static class DI
    {
        public static void AddApplicationDI(
            this IServiceCollection services)
        {
            services.AddScoped<IGHApiService, GHApiService>();
        }
    }
}
