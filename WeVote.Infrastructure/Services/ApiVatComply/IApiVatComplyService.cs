namespace WeVote.Infrastructure.Services.ApiVatComply
{
    public interface IApiVatComplyService
    {
        public Task<GetGeologationResponse> GetGeolocation();
        public Task<Dictionary<string, Currency>> GetCurrencies();
    }
}
