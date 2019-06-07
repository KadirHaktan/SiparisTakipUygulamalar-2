using Siparis.Core.Entities;
using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Siparis.MvcWebUI.Models
{
    public class EntityListModel
    {
        public List<Musteri> Musteriler { get; set; }
        public List<Urun> Urunler { get; set; }
        public List<_Siparis> Siparisler { get; set; }
        public List<Telefon> Telefonlar { get; set; }
        public List<Barkod> Barkodlar { get; set; }
    }
}