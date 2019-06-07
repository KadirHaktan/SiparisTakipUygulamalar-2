using Siparis.BusinessLogic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siparis.Entity;
using Siparis.DataAccess.Abstract;
using Siparis.Core.Aspect;
using Siparis.BusinessLogic.ValidationRules.Fluent_Validation;

namespace Siparis.BusinessLogic.Concart
{
    public class UrunManager : IUrunServices
    {
        private IUrunDAL urun_dal { get; set; }
        private IBarkodDAL barkod_dal { get; set; }

        public UrunManager(IUrunDAL _urunDal,IBarkodDAL _barkodDal)
        {
            this.urun_dal = _urunDal;
            this.barkod_dal = _barkodDal;
        }


        public List<Urun> GetAll()
        {
            return urun_dal.GetAll();
        }

        [_TransactionScopeAspect]
        [_FluentValidationAspect(typeof(UrunValidation))]
        [_FluentValidationAspect(typeof(BarkodValidation))]
        public void TransactionalAdd(Urun urun, Barkod barkod)
        {
            urun_dal.Add(urun);
            barkod_dal.Add(barkod);
        }

        [_TransactionScopeAspect]
        public void TransactionalDelete(Barkod barkod, Urun urun)
        {
            barkod_dal.Delete(barkod);
            urun_dal.Delete(urun);
            
        }

        [_TransactionScopeAspect]
        [_FluentValidationAspect(typeof(UrunValidation))]
        [_FluentValidationAspect(typeof(BarkodValidation))]
        public void TransactionalUpdate(Urun urun, Barkod barkod)
        {
            urun_dal.Update(urun);
            barkod_dal.Update(barkod);
        }
    }
}
