
using WeVote.Infrastructure.Services.ApiVatComply;

namespace WeVote.Infrastructure.Services
{
    public interface IApiVatComplyService
    {
        public Task<GetGeologationResponse> GetGeolocation();
        public void GetCurrencies();
    }
}
