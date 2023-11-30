using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using System.Text;
using WeVote.Client.Pages.GetGeolocation;
using WeVote.Client.Utils;

namespace WeVote.Client.Pages
{
    public partial class Index
    {
        public string BaseUrl = "https://localhost:44302";
        public GetGeolocationResult getGeolocationResult { get; set;} = new();
        public string currencyName { get; set; }

        private readonly WeVoteServiceConfig _config;

        public Index()
        {
            
        }
        public Index(IOptions<WeVoteServiceConfig> config)
        {
            _config = config.Value;
        }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                getGeolocationResult = await HttpClient
                                        .GetFromJsonAsync<GetGeolocationResult>
                                        ($"{BaseUrl}/geolocations");



                var currency = await HttpClient
                                        .GetFromJsonAsync<Currency>
                                        ($"{BaseUrl}/currencies?currency={getGeolocationResult.Currency}");

                currencyName = currency.Name;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching currency: {ex.Message}");
                currencyName = "Your country is not listed";

            }



        }

        protected override async Task OnAfterRenderAsync(bool render)
        {

            var view = new RegisterView.RegisterView
            {
                CountryCode = getGeolocationResult.CountryCode,
                CountryName = getGeolocationResult.Name,
                CurrencyName = currencyName,
                IpAddress = getGeolocationResult.Ip,

            };
            var json = System.Text.Json.JsonSerializer.Serialize(view);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var shortenedUrl = await HttpClient
                .PostAsync($"{BaseUrl}/webviews", data);
            Console.WriteLine(shortenedUrl);
            var responseStringContent = shortenedUrl.Content.ReadAsStringAsync().Result;

            Console.WriteLine(responseStringContent);




        }
    }
}
