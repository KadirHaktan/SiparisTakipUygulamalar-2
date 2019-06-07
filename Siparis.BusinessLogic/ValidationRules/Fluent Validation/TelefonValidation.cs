using FluentValidation;
using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.BusinessLogic.ValidationRules.Fluent_Validation
{
   public class TelefonValidation:AbstractValidator<Telefon>
    {
        public TelefonValidation()
        {
            RuleFor(t => t.TelefonNumarasi).Length(11).WithMessage("Telefon Numarası 11 karakter olmalıdır");
        }
    }
}
