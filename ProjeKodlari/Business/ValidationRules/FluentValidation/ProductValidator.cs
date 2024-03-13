using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   public class ProductValidator:AbstractValidator<Urun>
    {
        public ProductValidator()
        {
            RuleFor(p => p.UrunAd).NotEmpty();
            RuleFor(p => p.UrunAd).MinimumLength(2);
            RuleFor(p => p.UrunFiyat).NotEmpty();
            RuleFor(p => p.UrunFiyat).GreaterThan(0);
            RuleFor(p => p.UrunFiyat).GreaterThanOrEqualTo(10);
            RuleFor(p => p.UrunAd).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
