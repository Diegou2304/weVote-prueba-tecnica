using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using WeVote.Infrastructure.Services.ApiVatComply.Contract;

namespace Wevote.Application.Features.Geolocation.GetGeolocation
{
    public class GetGeolocationHandler : IRequestHandler<GetGeolocationQuery, IActionResult>
    {
        private readonly IApiVatComplyService _apiVatComplyService;
        private readonly ILogger _logger;

        public GetGeolocationHandler(IApiVatComplyService apiVatComplyService, ILogger<GetGeolocationHandler> logger)
        {
            _apiVatComplyService = apiVatComplyService;
            _logger = logger;
        }

        public async Task<IActionResult> Handle(GetGeolocationQuery request, CancellationToken cancellationToken)
        {
            LogStructure log = new LogStructure
            {
                HttpMethod = HttpMethod.Get,

                Route = "/geolocation",
                Result = HttpStatusCode.OK,
                Message = $"Geolocation was fetch correctly",

            };
            var response = await _apiVatComplyService.GetGeolocation();

            var geolocationResult = new GetGeolocationResult
            {
                Name = response.name,
                Ip = response.ip,
                CountryCode = response.country_code,
                Currency = response.currency
            };

            _logger.LogInformation("{@log}", log);
            return new OkObjectResult(geolocationResult);
        }
    }
}
