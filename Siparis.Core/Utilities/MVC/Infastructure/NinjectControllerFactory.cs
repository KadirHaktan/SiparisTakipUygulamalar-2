using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace Siparis.Core.Utilities.MVC.Infastructure
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel _kernel { get; set; }


        public NinjectControllerFactory(INinjectModule module)
        {
            _kernel = new StandardKernel(module);
        }


        protected override IController GetControllerInstance(RequestContext context, Type controllertype)
        {
            return controllertype == null ? null : (IController)_kernel.Get(controllertype);
        }
    }
}
