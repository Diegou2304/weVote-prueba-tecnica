using MediatR;
using Microsoft.AspNetCore.Mvc;
using Wevote.Application.Features.Geolocation.GetGeolocation;

namespace WeVote.Api.Controllers
{
    [ApiController]
    public class GeolocationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public GeolocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        [Route("[Controller]")]
        public async Task<IActionResult> GetGeolocation()
        {
            var query = new GetGeolocationQuery();  
            return await _mediator.Send(query);

        }
    }
}
