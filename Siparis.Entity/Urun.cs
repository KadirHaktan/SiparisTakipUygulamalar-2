using Siparis.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Entity
{
   public class Urun:IEntity
    {
        //[Key]
        public int Urun_ID { get; set; }

        public string Urun_Ad { get; set; }
        public int Urun_Stok_Miktari { get; set; }
        public decimal Urun_Fiyat { get; set; }

       //public virtual ICollection<Musteri> Musteriler { get; set; }
    }
}
