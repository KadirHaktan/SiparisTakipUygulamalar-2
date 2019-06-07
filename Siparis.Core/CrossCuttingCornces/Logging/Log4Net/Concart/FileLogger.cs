using Siparis.Core.CrossCuttingCornces.Logging.Log4Net.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Siparis.Core.CrossCuttingCornces.Logging.Log4Net.Concart
{
    public class FileLogger : LoggerService
    {
        public FileLogger() : base(LogManager.GetLogger("FileLogger"))
        {
        }
    }
}
