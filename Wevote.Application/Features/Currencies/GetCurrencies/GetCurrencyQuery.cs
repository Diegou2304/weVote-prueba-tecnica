
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Wevote.Application.Features.Currencies.GetCurrencies
{
    public class GetCurrencyQuery : IRequest<IActionResult>
    {
        public string Currency { get; set; }
    }
}
