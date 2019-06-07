using Siparis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.Entity
{
  public class Telefon:IEntity
    {
        public int Musteri_ID { get; set; }
        public string TelefonNumarasi { get; set; }
    }
}
