using WeVote.Infrastructure.Services.ApiVatComply.ServiceResponses;

namespace WeVote.Infrastructure.Services.ApiVatComply.Contract
{
    public interface IApiVatComplyService
    {
        public Task<GetGeologationResponse> GetGeolocation();
        public Task<Dictionary<string, Currency>> GetCurrencies();
    }
}
