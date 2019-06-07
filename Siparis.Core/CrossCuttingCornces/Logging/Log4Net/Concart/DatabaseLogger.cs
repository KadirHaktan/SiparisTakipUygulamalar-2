using Siparis.Core.CrossCuttingCornces.Logging.Log4Net.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Core;

namespace Siparis.Core.CrossCuttingCornces.Logging.Log4Net.Concart
{
    public class DatabaseLogger:LoggerService
    {
        public DatabaseLogger(ILog log) : base(LogManager.GetLogger("DatabaseLogger"))
        {
        }

        
    }
}
