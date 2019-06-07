using Siparis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Entity
{
   public class Barkod:IEntity
    {
        public int Urun_ID { get; set; }
        public string Barkod_Numarasi { get; set; }
    }
}
