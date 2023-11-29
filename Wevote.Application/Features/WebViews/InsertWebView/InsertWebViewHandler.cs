
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WeVote.Domain;
using WeVote.Infrastructure.Repositories;

namespace Wevote.Application.Features.WebViews.InsertWebView
{
    public class InsertWebViewHandler : IRequestHandler<InsertWebViewCommand, IActionResult>
    {
        private readonly IWebViewsRepository _webViewsRepository;

        public InsertWebViewHandler(IWebViewsRepository webViewsRepository)
        {
            _webViewsRepository = webViewsRepository;
        }

        public async Task<IActionResult> Handle(InsertWebViewCommand request, CancellationToken cancellationToken)
        {
            var webView = PageViews.Create(request.CountryName, request.CountryCode, request.CurrencyName, request.IpAddress);

            var result = await _webViewsRepository.RegisterWebView(webView);

            if (result) return new OkResult();

            return new BadRequestResult();
        }
    }
}
