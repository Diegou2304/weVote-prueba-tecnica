

using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using WeVote.Infrastructure.Services.ApiVatComply;

namespace WeVote.Infrastructure
{
    public static class InfrastructureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IApiVatComplyService, ApiVatComplyService>();
            services.AddHttpClient<ApiVatComplyService>();
            return services;
        }
    }
}
