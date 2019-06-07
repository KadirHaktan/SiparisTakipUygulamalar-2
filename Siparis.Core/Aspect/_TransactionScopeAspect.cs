using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp;
using PostSharp.Aspects;
using System.Transactions;
using System.Reflection;

namespace Siparis.Core.Aspect
{
    [Serializable]
   public class _TransactionScopeAspect:OnMethodBoundaryAspect
    {
        private TransactionScopeOption _option { get; set; }

        public _TransactionScopeAspect()
        {

        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag = new TransactionScope(_option);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Complete();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Dispose();
        }

    }
}
