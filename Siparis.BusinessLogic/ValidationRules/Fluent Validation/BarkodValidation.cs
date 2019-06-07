using FluentValidation;
using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.BusinessLogic.ValidationRules.Fluent_Validation
{
   public class BarkodValidation:AbstractValidator<Barkod>
    {
        public BarkodValidation()
        {
            RuleFor(b => b.Barkod_Numarasi).Length(5).WithMessage("Barkod numarası 5 karakter olmalı");
        }
    }
}
