

using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Text.Json;
using WeVote.Infrastructure.Services.ApiVatComply.Contract;
using WeVote.Infrastructure.Services.ApiVatComply.ServiceResponses;

namespace WeVote.Infrastructure.Services.ApiVatComply
{
    public class ApiVatComplyService : IApiVatComplyService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ApiVatComplySettings _serviceBaseUrl;

        public ApiVatComplyService( IHttpClientFactory httpClientFactory, IOptions<ApiVatComplySettings> options)
        {
            _httpClientFactory = httpClientFactory;
            _serviceBaseUrl = options.Value;
            
        }
        public  async Task<Dictionary<string, Currency>> GetCurrencies()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var result = await httpClient.GetAsync($"{_serviceBaseUrl.BaseUrl}/currencies");
            var jsonString = await result.Content.ReadAsStringAsync();
            var getCurrenciesResponse = JsonSerializer.Deserialize<Dictionary<string, Currency>>(jsonString);
            return getCurrenciesResponse;
        }

        public async Task<GetGeologationResponse?> GetGeolocation()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var result = await httpClient.GetAsync($"{_serviceBaseUrl.BaseUrl}/geolocate");
            var jsonString = await result.Content.ReadAsStringAsync();
            var getGeolocationResponse = JsonSerializer.Deserialize<GetGeologationResponse>(jsonString);
            return getGeolocationResponse;
        }
    }
}
