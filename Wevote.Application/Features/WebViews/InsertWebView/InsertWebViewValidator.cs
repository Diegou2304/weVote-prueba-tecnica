using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wevote.Application.Features.WebViews.InsertWebView
{
    public class InsertWebViewValidator : AbstractValidator<InsertWebViewCommand>
    {
        public InsertWebViewValidator()
        {
            RuleFor(
                x => x.CurrencyName).NotNull().NotEmpty();

            RuleFor(
                x => x.CountryName).NotNull().NotEmpty();


            RuleFor(
                x => x.CountryCode).NotNull().NotEmpty();

            RuleFor(
                x => x.IpAddress).NotNull().NotEmpty();

        }
    }
}
