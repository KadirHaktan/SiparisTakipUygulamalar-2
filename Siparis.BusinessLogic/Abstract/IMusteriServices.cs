using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.BusinessLogic.Abstract
{
   public interface IMusteriServices
    {
        List<Musteri> GetAllCustomers();

        List<Telefon> GetAllPhones();

        Musteri AddCustomer(Musteri musteri);

        Musteri DeleteCustomer(Musteri musteri);

        Musteri UpdateCustomer(Musteri musteri);


       // Telefon AddPhone(Telefon telefon);

       // Telefon DeletePhone(Telefon telefon);

       // Telefon UpdatePhone(Telefon telefon);

        void TransactionalAdd(Musteri musteri, Telefon telefon);

        void TransactionalUpdate(Musteri musteri, Telefon telefon);

        void TransactionalDelete(Telefon telefon, Musteri musteri);



        
    }
}
