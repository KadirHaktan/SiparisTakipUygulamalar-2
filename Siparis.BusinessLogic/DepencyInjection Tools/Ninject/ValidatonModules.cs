using FluentValidation;
using Ninject.Modules;
using Siparis.BusinessLogic.ValidationRules.Fluent_Validation;
using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.BusinessLogic.DepencyInjection_Tools.Ninject
{
    public class ValidatonModules : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Musteri>>().To<MusteriValidation>().InSingletonScope();
            Bind<IValidator<Telefon>>().To<TelefonValidation>().InSingletonScope();
            Bind<IValidator<Urun>>().To<UrunValidation>().InSingletonScope();
            Bind<IValidator<Barkod>>().To<BarkodValidation>().InSingletonScope();
        }
    }
}
