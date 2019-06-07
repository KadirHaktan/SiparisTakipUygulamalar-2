using Ninject.Modules;
using Siparis.BusinessLogic.Abstract;
using Siparis.BusinessLogic.Concart;
using Siparis.DataAccess.Abstract;
using Siparis.DataAccess.Concart.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.BusinessLogic.DepencyInjection_Tools.Ninject
{
    public class Business_Modules : NinjectModule
    {
        public override void Load()
        {
            Bind<IMusteriServices>().To<MusteriManager>().InSingletonScope();
            Bind<IUrunServices>().To<UrunManager>().InSingletonScope();
            Bind<ISiparisServices>().To<SiparisManager>().InSingletonScope();

            Bind<IMusteriDAL>().To<EntityFrameworkMusteriDAL>().InSingletonScope();
            Bind<ITelefonDAL>().To<EntityFrameworkTelefonDAL>().InSingletonScope();
            Bind<IUrunDAL>().To<EntityFrameworkUrunDAL>().InSingletonScope();
            Bind<IBarkodDAL>().To<EntityFrameworkBarkodDAL>().InSingletonScope();
            Bind<ISiparisDAL>().To<EntityFrameworkSiparisDAL>().InSingletonScope();

            Bind<DbContext>().To<SiparisContext>();
        }
    }
}
