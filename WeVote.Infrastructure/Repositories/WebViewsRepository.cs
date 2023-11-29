
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Net;
using WeVote.Domain;

namespace WeVote.Infrastructure.Repositories
{
    public class WebViewsRepository : IWebViewsRepository
    {
        private readonly string _connectionString;
        
        public WebViewsRepository(IOptions<ConnectionStringConfig> connectionString)
        {
            _connectionString = connectionString.Value.WeVoteConnectionString;
            
        }
        public async Task<bool> RegisterWebView(PageViews pageViews)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "insert into WebViews values (@CountryName, @CountryCode, @CurrencyName, @IpAddress)";

            var param = new
            {
                CountryName = pageViews.CountryName,
                CountryCode = pageViews.CountryCode,
                CurrencyName = pageViews.CurrencyName,
                IPAddress = pageViews.IpAddress

            };

            return await connection.ExecuteAsync(query, param) > 0 ;
        }
    }
}
    