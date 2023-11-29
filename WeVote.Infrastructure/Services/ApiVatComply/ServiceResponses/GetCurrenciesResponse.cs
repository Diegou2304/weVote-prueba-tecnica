

using Newtonsoft.Json;

namespace WeVote.Infrastructure.Services.ApiVatComply.ServiceResponses
{
    public class Currency
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("symbol")]
        public string symbol { get; set; }
    }


}
