using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.BusinessLogic.DepencyInjection_Tools
{
    public class InstanceFactory
    {
        public static T CreateInstance<T>()
        {
            var kernel = new StandardKernel();

            return kernel.Get<T>();
        }
    }
}
