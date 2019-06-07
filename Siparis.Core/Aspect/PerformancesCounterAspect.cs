using PostSharp.Aspects;
using Siparis.Core.CrossCuttingCornces.Logging.Log4Net.Concart;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Core.Aspect
{
    [Serializable]
  public class PerformancesCounterAspect:OnMethodBoundaryAspect
    {
        [NonSerialized]
        Stopwatch _stopwatch;

        private int interval { get; set; }

        public PerformancesCounterAspect(int interval=3)
        {
            this.interval = interval;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            _stopwatch.Start();

            base.OnEntry(args);
        }

        [LogAspect(typeof(FileLogger))]
        public override void OnExit(MethodExecutionArgs args)
        {
            _stopwatch.Stop();

            if (_stopwatch.Elapsed.TotalSeconds > interval)
            {
                Debug.WriteLine("Performance problem:{0}.{1}=>{2}", args.Method.ReflectedType.FullName, args.Method.Name, _stopwatch.Elapsed.TotalSeconds);
            }

           

            base.OnExit(args);
        }
    }
}
