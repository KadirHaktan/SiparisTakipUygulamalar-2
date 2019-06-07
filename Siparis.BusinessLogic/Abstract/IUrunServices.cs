using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.BusinessLogic.Abstract
{
   public interface IUrunServices
    {
        List<Urun> GetAll();

        void TransactionalAdd(Urun urun, Barkod barkod);

        void TransactionalUpdate(Urun urun, Barkod barkod);

        void TransactionalDelete(Barkod barkod, Urun urun);
    }
}
