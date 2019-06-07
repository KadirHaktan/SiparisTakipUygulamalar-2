using FluentValidation;
using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.BusinessLogic.ValidationRules.Fluent_Validation
{
    public class MusteriValidation:AbstractValidator<Musteri>
    {
        public MusteriValidation()
        {
            RuleFor(m => m.Ad).MinimumLength(3).WithMessage("Müşterinin adı en az üç karakter olmalı");
            RuleFor(m => m.Soyad).MinimumLength(2).WithMessage("Müşterinin soyadı en az iki karakter olmalı");
        }
    }
}
