using MediatR;
using Microsoft.AspNetCore.Mvc;
using WeVote.Infrastructure.Services;

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

            return new OkObjectResult(response);
        }
    }
}
