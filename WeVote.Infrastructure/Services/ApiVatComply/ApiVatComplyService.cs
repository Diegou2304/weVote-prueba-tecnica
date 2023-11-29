

using System.Net.Http;
using System.Text.Json;

namespace WeVote.Infrastructure.Services.ApiVatComply
{
    public class ApiVatComplyService : IApiVatComplyService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ApiVatComplyService( IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            
        }
        public  void GetCurrencies()
        {

            throw new NotImplementedException();
        }

        public async Task<GetGeologationResponse?> GetGeolocation()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var result = await httpClient.GetAsync("https://api.vatcomply.com/geolocate");
            var jsonString = await result.Content.ReadAsStringAsync();
            var getGeolocationResponse = JsonSerializer.Deserialize<GetGeologationResponse>(jsonString);
            return getGeolocationResponse;
        }
    }
}
