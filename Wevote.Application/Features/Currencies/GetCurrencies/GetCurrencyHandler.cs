using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using WeVote.Infrastructure.Services.ApiVatComply.Contract;

namespace Wevote.Application.Features.Currencies.GetCurrencies
{
    public class GetCurrencyHandler : IRequestHandler<GetCurrencyQuery, IActionResult>
    {
        private readonly IApiVatComplyService _apiVatComplyService;
        private readonly ILogger<GetCurrencyHandler> _logger;

        public GetCurrencyHandler(IApiVatComplyService apiVatComplyService, ILogger<GetCurrencyHandler> logger)
        {
            _apiVatComplyService = apiVatComplyService;
            _logger = logger;
        }
        public async Task<IActionResult> Handle(GetCurrencyQuery request, CancellationToken cancellationToken)
        {
            LogStructure log = new LogStructure
            {
                HttpMethod = HttpMethod.Get,

                Route = "/currencies",
                Result = HttpStatusCode.OK,
                Message = $"Currencies were fetch correctly",

            };
            var result = await _apiVatComplyService.GetCurrencies();

            
            if (request.Currency is null)
            {
                _logger.LogInformation("{@log}", log);
                return new OkObjectResult(result);
            }

            if (!result.ContainsKey(request.Currency))
            {
                log.Result = HttpStatusCode.NotFound;
                log.Message = "The requested currency could not be found";
                _logger.LogError("{@log}", log);
                return new NotFoundObjectResult(new { Message = $"The currency requested is could not be found [{request.Currency}]" });

            }

            _logger.LogInformation("{@log}", log);
            return new OkObjectResult(result[request.Currency]);
         

        }
    }
}
