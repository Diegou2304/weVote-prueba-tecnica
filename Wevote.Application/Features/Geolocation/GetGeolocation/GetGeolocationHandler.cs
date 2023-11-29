using MediatR;
using Microsoft.AspNetCore.Mvc;
using WeVote.Infrastructure.Services.ApiVatComply;

namespace Wevote.Application.Features.Geolocation.GetGeolocation
{
    public class GetGeolocationHandler : IRequestHandler<GetGeolocationQuery, IActionResult>
    {
        private readonly IApiVatComplyService _apiVatComplyService;

        public GetGeolocationHandler(IApiVatComplyService apiVatComplyService)
        {
            _apiVatComplyService = apiVatComplyService;
        }

        public async Task<IActionResult> Handle(GetGeolocationQuery request, CancellationToken cancellationToken)
        {
            var response = await _apiVatComplyService.GetGeolocation();

            var geolocationResult = new GetGeolocationResult
            {
                Name = response.name,
                Ip = response.ip,
                CountryCode = response.country_code,
                Currency = response.currency
            };
            return new OkObjectResult(geolocationResult);
        }
    }
}
