using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.BusinessLogic.Abstract
{
   public interface ISiparisServices
    {
        List<_Siparis> GetAll();

        _Siparis Add(_Siparis siparis);

        _Siparis Update(_Siparis siparis);

        _Siparis Delete(_Siparis siparis);
    }
}
