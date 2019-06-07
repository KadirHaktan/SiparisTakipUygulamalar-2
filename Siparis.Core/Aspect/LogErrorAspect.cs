using PostSharp.Aspects;
using PostSharp.Extensibility;
using Siparis.Core.CrossCuttingCornces.Logging.Log4Net.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Siparis.Core.Aspect
{
    [Serializable]
   public class LogErrorAspect:OnExceptionAspect
    { 
        private Type _logType { get; set; }
        private LoggerService _services { get; set; }

        public LogErrorAspect(Type _logType)
        {
            this._logType = _logType;
        }

        public override void RuntimeInitialize(MethodBase method)
        {

            if (_logType.BaseType != typeof(LoggerService))
            {
                throw new Exception("Wrong log type");
            }

            _services = (LoggerService)Activator.CreateInstance(_logType);

            base.RuntimeInitialize(method);
        }

        public override void OnException(MethodExecutionArgs args)
        {
            if (_services != null)
            {
                _services.Error(args.Exception);
            }

            base.OnException(args);
        }
    }
}
