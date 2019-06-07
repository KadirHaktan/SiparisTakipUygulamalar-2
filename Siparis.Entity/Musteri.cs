using Siparis.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Entity
{
    public class Musteri:IEntity
    {
        
        public int Musteri_ID { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TamAdres { get; set; }

        //public virtual ICollection<Urun> Urunler { get; set; }
    }
}
