
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using WeVote.Domain;
using WeVote.Infrastructure.Repositories;

namespace Wevote.Application.Features.WebViews.InsertWebView
{
    public class InsertWebViewHandler : IRequestHandler<InsertWebViewCommand, IActionResult>
    {
        private readonly IWebViewsRepository _webViewsRepository;
        private readonly ILogger<InsertWebViewCommand> _logger;



        public InsertWebViewHandler(IWebViewsRepository webViewsRepository, ILogger<InsertWebViewCommand> logger)
        {
            _webViewsRepository = webViewsRepository;
            _logger = logger;
        }

        public async Task<IActionResult> Handle(InsertWebViewCommand request, CancellationToken cancellationToken)
        {
            LogStructure log = new LogStructure
            {
                HttpMethod = HttpMethod.Post,
                Route = "/webviews",
                Result = HttpStatusCode.OK,
                Message = $"Web View was inserted correctly",

            };
            var webView = PageViews.Create(
                                    request.CountryName, 
                                    request.CountryCode, 
                                    request.CurrencyName, 
                                    request.IpAddress);

            var result = await _webViewsRepository.RegisterWebView(webView);

            if (result)
            {
                _logger.LogInformation("{@log}", log);

                return new OkResult();
            }


            log.Result = HttpStatusCode.BadRequest;
            log.Message = "The WebView could not be inserted";
            _logger.LogError("{@log}", log);
            return new BadRequestResult();
        }
    }
}
