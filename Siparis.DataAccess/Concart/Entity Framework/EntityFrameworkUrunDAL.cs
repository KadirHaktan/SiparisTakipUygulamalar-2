using Siparis.Core.DataAccessLayer.Concart.EntityFramework;
using Siparis.DataAccess.Abstract;
using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.DataAccess.Concart.Entity_Framework
{
  public  class EntityFrameworkUrunDAL:EntityFrameworkRepository<Urun,SiparisContext>,IUrunDAL
    {
    }
}
