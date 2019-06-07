using FluentValidation;
using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.BusinessLogic.ValidationRules.Fluent_Validation
{
    public class UrunValidation:AbstractValidator<Urun>
    {
        public UrunValidation()
        {
            RuleFor(u => u.Urun_Ad).MinimumLength(3).WithMessage("Ürün adı en az üç karakter olmalı");
        }
    }
}
