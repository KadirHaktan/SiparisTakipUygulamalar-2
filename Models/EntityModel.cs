using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Siparis.MvcWebUI.Models
{
    public class EntityModel
    {
        public Musteri musteri { get; set; }
        public Urun urun { get; set; }
        public _Siparis siparis { get; set; }
        public Telefon telefon { get; set; }
        public Barkod barkod { get; set; }

       //public List<Musteri> Musteriler { get; set; }
       //public List<Telefon> Telefonlar { get; set; }
    }
}