

using System.Net;

namespace WeVote.Domain
{
    public class PageViews
    {
        private PageViews(string countryName, string countryCode, string currencyName, string ipAddress)
        {
            CountryName = countryName;
            CountryCode = countryCode;
            CurrencyName = currencyName;
            IpAddress = ipAddress;
        }

        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CurrencyName { get; set; }
        public string IpAddress { get; set; }
        public static PageViews Create(string countryName, string countryCode, string currencyName, string ipAddress)
        {
            return new PageViews(countryName, countryCode, currencyName, ipAddress);
        }
    }

   
}
