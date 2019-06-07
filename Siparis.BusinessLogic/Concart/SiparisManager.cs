using Siparis.BusinessLogic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siparis.Entity;
using Siparis.DataAccess.Abstract;
using Siparis.Core.Aspect;
using Siparis.Core.CrossCuttingCornces.Caching.Concart.Microsoft;

namespace Siparis.BusinessLogic.Concart
{
    public class SiparisManager : ISiparisServices
    {
        private ISiparisDAL _siparisDal { get; set; }


        public SiparisManager(ISiparisDAL _Dal)
        {
            this._siparisDal = _Dal;
        }

        //[CacheAspect(typeof(MemoryCacheManager))]
        public _Siparis Add(_Siparis siparis)
        {
            return _siparisDal.Add(siparis);
        }

        public _Siparis Delete(_Siparis siparis)
        {
           return _siparisDal.Delete(siparis);
        }

        //[CacheAspect(typeof(MemoryCacheManager))]
        public List<_Siparis> GetAll()
        {
            return _siparisDal.GetAll();
        }

        //[CacheAspect(typeof(MemoryCacheManager))]
        public _Siparis Update(_Siparis siparis)
        {
            return _siparisDal.Update(siparis);
        }
    }
}
