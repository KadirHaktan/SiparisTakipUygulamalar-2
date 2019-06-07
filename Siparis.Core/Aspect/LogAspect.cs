using PostSharp.Aspects;
using PostSharp.Extensibility;
using Siparis.Core.CrossCuttingCornces.Logging.Log4Net.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Siparis.Core.CrossCuttingCornces.Logging.Log4Net;
using log4net;

namespace Siparis.Core.Aspect
{

    [Serializable]
    [MulticastAttributeUsage(MulticastTargets.Method, TargetMemberAttributes = MulticastAttributes.Instance)]
    public class LogAspect : OnMethodBoundaryAspect
    {
        private Type _logType { get; set; }//log type
        private LoggerService _loggerservices { get; set; }// diğer loglara servis eden log sınıfı

        public LogAspect(Type logType)
        {
            this._logType = logType; //Depency Injection yapısı
        }


        public override void RuntimeInitialize(MethodBase method)//Nesne üretildiğinde ya da nesne çalışma zamanı initalize edildiğinde
        {
            if (_logType.BaseType != typeof(LoggerService))//eğer base tip ILog değilse
            {
                throw new Exception("Wrong logging type");
            }

            _loggerservices = (LoggerService)Activator.CreateInstance(_logType);//loggerservices nesnesi üretiliyor _logtype a göre


            base.RuntimeInitialize(method);
        }


        public override void OnEntry(MethodExecutionArgs args)
        {
            try
            {
                var logParameters = args.Method.GetParameters().Select((t, i) => new LogParameter
                {

                    ParameterType = t.ParameterType.Name,
                    ParameterName = t.Name,
                    ParameterValue = args.Arguments.GetArgument(i)//parametre değerleri kaç tane varsa hepsini argüman olarak kabul
                                                                  //edip get ile her bir argümanın indexine erişilerek alınır

                }).ToList();


                var logDetail = new LogDetail
                {
                    FullName = args.Method.DeclaringType == null ? null : args.Method.DeclaringType.Name,
                    MethodName = args.Method.Name,
                    Parameters = logParameters
                };

                _loggerservices.Info(logDetail);//loglama işlemi gerçekleşir bilgi döndürerek bize loglamayı gerçekleştirir

            }

            catch (Exception)
            {

            }




            base.OnEntry(args);
        }
    }
}

