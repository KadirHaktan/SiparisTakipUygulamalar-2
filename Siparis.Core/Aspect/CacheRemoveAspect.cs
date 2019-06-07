using PostSharp.Aspects;
using Siparis.Core.CrossCuttingCornces.Caching.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Siparis.Core.Aspect
{
    [Serializable]
    public class CacheRemoveAspect:OnMethodBoundaryAspect
    {
        private string pattern { get; set; }
        private Type _CacheType { get; set; }

        private ICacheManager manager { get; set; }

        public CacheRemoveAspect(Type type,string pattern)
        {
            this._CacheType = type;
            this.pattern = pattern;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            if (_CacheType.IsAssignableFrom(typeof(ICacheManager)) == false)
            {
                throw new Exception("Wrong Cache type");
            }

            manager = (ICacheManager)Activator.CreateInstance(_CacheType);
            


            base.RuntimeInitialize(method);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            manager.RemovebyPattern(string.IsNullOrEmpty(pattern) ? string.Format("{0}.{1}", args.Method.ReflectedType.Namespace, args.Method.ReflectedType.Name) : pattern);

            base.OnSuccess(args);
        }
    }
}
