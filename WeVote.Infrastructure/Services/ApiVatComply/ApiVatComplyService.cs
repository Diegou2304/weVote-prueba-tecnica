

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Text.Json;
using WeVote.Infrastructure.Services.ApiVatComply.Contract;
using WeVote.Infrastructure.Services.ApiVatComply.ServiceResponses;
using WeVote.Infrastructure.Utils;

namespace WeVote.Infrastructure.Services.ApiVatComply
{
    public class ApiVatComplyService : IApiVatComplyService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ApiVatComplySettings _serviceBaseUrl;
        private readonly ILogger _logger;

        public ApiVatComplyService(IHttpClientFactory httpClientFactory, IOptions<ApiVatComplySettings> options, ILogger<ApiVatComplyService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _serviceBaseUrl = options.Value;
            _logger = logger;
        }
        public  async Task<Dictionary<string, Currency>> GetCurrencies()
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();
                var result = await httpClient.GetAsync($"{_serviceBaseUrl.BaseUrl}/currencies");

                result.EnsureSuccessStatusCode();

                var jsonString = await result.Content.ReadAsStringAsync();
                var getCurrenciesResponse = JsonSerializer.Deserialize<Dictionary<string, Currency>>(jsonString);
                return getCurrenciesResponse;

            }
            catch(HttpRequestException ex)
            {
                _logger.LogError("An error occured trying to obtain information from the API");
                throw;
            }
            catch(JsonException ex)
            {
                _logger.LogError("An error occured trying to deserialize JSON");
                throw;
            }
          
        }

        public async Task<GetGeologationResponse?> GetGeolocation()
        {
            try
            {

                var httpClient = _httpClientFactory.CreateClient();
                var result = await httpClient.GetAsync($"{_serviceBaseUrl.BaseUrl}/geolocate");

                result.EnsureSuccessStatusCode();
                var jsonString = await result.Content.ReadAsStringAsync();
                var getGeolocationResponse = JsonSerializer.Deserialize<GetGeologationResponse>(jsonString);

                return getGeolocationResponse;

            }

            catch (HttpRequestException ex)
            {
                _logger.LogError("An error occured trying to obtain information from the API");
                throw;
            }
            catch (JsonException ex)
            {
                _logger.LogError("An error occured trying to deserialize JSON");
                throw;
            }
        }
    }
}
