using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Wevote.Application.Features.WebViews.InsertWebView
{
    public class InsertWebViewCommand : IRequest<IActionResult>
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CurrencyName { get; set; }
        public string IpAddress { get; set; }
    }
}