
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Wevote.Application.Features.Geolocation.GetGeolocation
{
    public class GetGeolocationQuery : IRequest<IActionResult>
    {
    }
}
