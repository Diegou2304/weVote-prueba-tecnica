using MediatR;
using Microsoft.AspNetCore.Mvc;
using Wevote.Application.Features.WebViews.InsertWebView;

namespace WeVote.Api.Controllers
{
    [ApiController]
    public class WebViewsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public WebViewsController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpPost("/webviews")]
        public async Task<IActionResult> InsertWebView([FromBody] InsertWebViewCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
