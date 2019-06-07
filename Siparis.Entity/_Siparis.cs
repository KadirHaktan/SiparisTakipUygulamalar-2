using Siparis.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Entity
{
   public class _Siparis:IEntity
    {
        public int Siparis_ID { get; set; }
        public int Musteri_ID { get; set; }    
        public int Urun_ID { get; set; }
        public int Adet { get; set; }
        public DateTime Tarih { get; set; }
    }
}
