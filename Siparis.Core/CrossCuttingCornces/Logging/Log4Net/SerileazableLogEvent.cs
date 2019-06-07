using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Core.CrossCuttingCornces.Logging.Log4Net
{
    [Serializable]
   public class SerileazableLogEvent
    {
        public LoggingEvent _loggingEvent { get; set; }

        public SerileazableLogEvent(LoggingEvent _event)
        {
            this._loggingEvent = _event;
        }

        public string UserName => _loggingEvent.UserName;
        //public DateTime DateTime => DateTime.Now;
        public object Message => _loggingEvent.MessageObject;
    }
}
