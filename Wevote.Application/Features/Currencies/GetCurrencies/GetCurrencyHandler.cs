

using MediatR;
using Microsoft.AspNetCore.Mvc;
using WeVote.Infrastructure.Services.ApiVatComply;

namespace Wevote.Application.Features.Currencies.GetCurrencies
{
    public class GetCurrencyHandler : IRequestHandler<GetCurrencyQuery, IActionResult>
    {
        private readonly IApiVatComplyService _apiVatComplyService;

        public GetCurrencyHandler(IApiVatComplyService apiVatComplyService)
        {
            _apiVatComplyService = apiVatComplyService;
        }
        public async Task<IActionResult> Handle(GetCurrencyQuery request, CancellationToken cancellationToken)
        {
            var result = await _apiVatComplyService.GetCurrencies();

            return new OkObjectResult(result);
        }
    }
}
