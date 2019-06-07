using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Core.CrossCuttingCornces.Logging.Log4Net
{
   public class LogParameter
    {
        public string ParameterName { get; set; }
        public string ParameterType { get; set; }
        public object ParameterValue { get; set; }
    }
}
