

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeVote.Infrastructure.Repositories;
using WeVote.Infrastructure.Services.ApiVatComply;
using WeVote.Infrastructure.Services.ApiVatComply.Contract;
using WeVote.Infrastructure.Utils;

namespace WeVote.Infrastructure
{
    public static class InfrastructureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IApiVatComplyService, ApiVatComplyService>();
            services.AddScoped<IWebViewsRepository, WebViewsRepository>();
            services.AddHttpClient<ApiVatComplyService>();
            services.Configure<ApiVatComplySettings>(configuration.GetSection("ApiVatComplySettings"));
            services.Configure<ConnectionStringConfig>(configuration.GetSection("ConnectionStrings"));
            
            return services;
        }
    }
}
