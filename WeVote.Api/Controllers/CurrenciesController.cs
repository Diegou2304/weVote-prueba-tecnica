using MediatR;
using Microsoft.AspNetCore.Mvc;
using Wevote.Application.Features.Currencies.GetCurrencies;

namespace WeVote.Api.Controllers
{
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CurrenciesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/currencies")]
        public async Task<IActionResult> GetCurrency([FromQuery] string? currency)
        {
            var getCurrencyQuery = new GetCurrencyQuery
            {
                Currency = currency
            };
            return await _mediator.Send(getCurrencyQuery); 
        }
    }
}
