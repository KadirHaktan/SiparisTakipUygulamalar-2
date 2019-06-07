using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.DataAccess.Concart.Entity_Framework.Mapping
{
   public class SiparisMapping:EntityTypeConfiguration<_Siparis>
    {
        public SiparisMapping()
        {
            ToTable(@"_Siparis", @"dbo");


            HasKey(s => s.Siparis_ID);

            Property(s => s.Siparis_ID).HasColumnName("Siparis_ID");
            Property(s => s.Urun_ID).HasColumnName("Urun_ID");
            Property(s => s.Musteri_ID).HasColumnName("Musteri_ID");

            Property(s => s.Adet).HasColumnName("Adet");
            Property(s => s.Tarih).HasColumnName("Tarih");
        }
    }
}
