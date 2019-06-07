using FluentValidation;
using PostSharp.Aspects;
using Siparis.Core.Validations.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Core.Aspect
{
    [Serializable]
   public class _FluentValidationAspect:OnMethodBoundaryAspect
    {
        private Type validationType { get; set; }

        public _FluentValidationAspect(Type _type)
        {
            this.validationType = _type;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(validationType);//validasyon nesnesi oluşturuluyor
            var entityType = validationType.BaseType.GetGenericArguments()[0];//validasyon nesne tiplerinde ilk olanı alıyoruz
            var entities = args.Arguments.Where(t => t.GetType() == entityType).ToList();//argümanlardaki tip validasyon tipine eşit olanları listele


            foreach(var e in entities)
            {
                FluentValidationTool.Validate(validator, e);
            }
            
        }


    }
}
