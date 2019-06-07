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
  public class CacheAspect:MethodInterceptionAspect
    {
        private Type Cachetype { get; set; }
        private ICacheManager manager { get; set; }
        private int CacheByMinute { get; set; }

        public CacheAspect(Type cachetype,int CacheByMinute=60)
        {
            this.Cachetype = cachetype;
            this.CacheByMinute = CacheByMinute;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            try
            {
                if (typeof(ICacheManager).IsAssignableFrom(Cachetype) == false)
                {
                    throw new Exception("Wrong Cache Type");
                }

                manager = (ICacheManager)Activator.CreateInstance(Cachetype);

                base.RuntimeInitialize(method);
            }

            catch(InvalidOperationException exception)
            {
                
            }
          
            
        }

        public override void OnInvoke(MethodInterceptionArgs args)
        {
            var methodProperty = string.Format("{0}.{1}.{2}", args.Method.ReflectedType.Namespace, args.Method.ReflectedType.Name, args.Method.Name);

            var arguments = args.Arguments.ToList();

            var key = string.Format("{0}.({1})", methodProperty, string.Join(",", arguments.Select(a => a != null ? a.ToString() : "<Null>")));

            if (manager.IsAdd(key))
            {
                manager.Get<object>(key);
            }

            manager.Add(key, args.ReturnValue, CacheByMinute);
        }
    }
}
