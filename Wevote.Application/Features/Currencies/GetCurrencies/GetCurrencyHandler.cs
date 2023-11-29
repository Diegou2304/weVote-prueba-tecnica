

using MediatR;
using Microsoft.AspNetCore.Mvc;
using WeVote.Infrastructure.Services.ApiVatComply.Contract;

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

            
            if (request.Currency is not null)
            {
                if (!result.ContainsKey(request.Currency))
                    return new NotFoundObjectResult(new { Message = $"The currency requested is could not be found [{request.Currency}]" });


                return new OkObjectResult(result[request.Currency]);


            }

            return new OkObjectResult(result);


        }
    }
}
