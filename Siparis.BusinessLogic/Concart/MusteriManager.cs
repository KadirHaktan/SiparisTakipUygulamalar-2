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
using Siparis.Core.CrossCuttingCornces.Logging.Log4Net.Concart;
using Siparis.Core.CrossCuttingCornces.Caching.Concart.Microsoft;

namespace Siparis.BusinessLogic.Concart
{
    public class MusteriManager : IMusteriServices
    {

        private IMusteriDAL musteri_dal { get; set; }
        private ITelefonDAL telefon_dal { get; set; }

        public MusteriManager(IMusteriDAL _MusteriDAL,ITelefonDAL _TelefonDAL)
        {
            this.musteri_dal = _MusteriDAL;
            this.telefon_dal = _TelefonDAL;
        }

       


       //[CacheAspect(typeof(MemoryCacheManager))]
        public List<Musteri> GetAllCustomers() => musteri_dal.GetAll();

        [_TransactionScopeAspect]
        [_FluentValidationAspect(typeof(MusteriValidation))]
        [_FluentValidationAspect(typeof(TelefonValidation))]
        public void TransactionalAdd(Musteri musteri,Telefon telefon)
        {
           musteri_dal.Add(musteri);
           telefon_dal.Add(telefon);
        }

        [_TransactionScopeAspect]
         public void TransactionalDelete(Telefon telefon, Musteri musteri)
         {
          telefon_dal.Delete(telefon);
          musteri_dal.Delete(musteri);
          }

        [_TransactionScopeAspect]
        [_FluentValidationAspect(typeof(MusteriValidation))]
        [_FluentValidationAspect(typeof(TelefonValidation))]
        //[CacheAspect(typeof(MemoryCacheManager))]
        public void TransactionalUpdate(Musteri musteri, Telefon telefon)
        {
          musteri_dal.Update(musteri);
          telefon_dal.Update(telefon);
        }


        public List<Telefon> GetAllPhones()
        {
         return telefon_dal.GetAll();
        }

        public Musteri AddCustomer(Musteri musteri)
        {
            return musteri_dal.Add(musteri);
        }

        public Musteri DeleteCustomer(Musteri musteri)
        {
            return musteri_dal.Delete(musteri);
        }

        public Musteri UpdateCustomer(Musteri musteri)
        {
            return musteri_dal.Update(musteri);
        }


    }
}
