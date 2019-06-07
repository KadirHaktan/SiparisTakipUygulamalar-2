using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Core.CrossCuttingCornces.Logging.Log4Net.Abstract
{
    [Serializable]
   public class LoggerService
    {
        private ILog log { get; set; }

        public LoggerService(ILog log)
        {
            this.log = log;
        }

        public bool IsInfoEnable => log.IsInfoEnabled;
        public bool IsErrorEnable => log.IsErrorEnabled;
        public bool IsDebugEnable => log.IsDebugEnabled;
        public bool IsWarnEnable => log.IsWarnEnabled;
        public bool IsFatalEnable => log.IsFatalEnabled;


        public void Info(object message)
        {
            if (IsInfoEnable)
            {
                log.Info(message);
            }        
        }

        public void Debug(object message)
        {
            if (IsDebugEnable)
            {
                log.Debug(message);
            }
        }

        public void Error(object message)
        {
            if (IsErrorEnable)
            {
                log.Error(message);
            }
        }

        public void Warn(object message)
        {
            if (IsWarnEnable)
            {
                log.Warn(message);
            }
        }

        public void Fatal(object message)
        {
            if (IsFatalEnable)
            {
                log.Fatal(message);
            }
        }


    }
}
