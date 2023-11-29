

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeVote.Infrastructure.Services.ApiVatComply;
using WeVote.Infrastructure.Services.ApiVatComply.Contract;

namespace WeVote.Infrastructure
{
    public static class InfrastructureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IApiVatComplyService, ApiVatComplyService>();
            services.AddHttpClient<ApiVatComplyService>();
            services.Configure<ApiVatComplySettings>(configuration.GetSection("ApiVatComplySettings"));
            return services;
        }
    }
}
