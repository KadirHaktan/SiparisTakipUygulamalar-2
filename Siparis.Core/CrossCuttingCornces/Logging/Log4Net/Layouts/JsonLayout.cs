using log4net.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;
using System.IO;

namespace Siparis.Core.CrossCuttingCornces.Logging.Log4Net.Layouts
{
    class JsonLayout : LayoutSkeleton
    {
        public override void ActivateOptions()
        {
           
        }

        public override void Format(TextWriter writer, LoggingEvent loggingEvent)
        {
            var serileazableLogEvent = new SerileazableLogEvent(loggingEvent);

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(serileazableLogEvent,Newtonsoft.Json.Formatting.Indented);

            writer.WriteLine(json);


        }
    }
}
