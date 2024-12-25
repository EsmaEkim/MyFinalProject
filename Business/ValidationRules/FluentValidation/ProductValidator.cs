using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(P => P.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(P => P.UnitPrice).NotEmpty();
            RuleFor(P => P.UnitPrice).GreaterThan(0);
            RuleFor(P => P.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1).WithMessage("Der Einzelpreis muss größer als 10 Euro sein.");
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Produkte müssen mit dem Buchstaben A beginnen");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
