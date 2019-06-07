using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.DataAccess.Concart.Entity_Framework.Mapping
{
   public class MusteriMapping:EntityTypeConfiguration<Musteri>
    {
        public MusteriMapping()
        {
            ToTable(@"Musteri", @"dbo");

            HasKey(m => m.Musteri_ID);

            Property(m => m.Musteri_ID).HasColumnName("Musteri_ID");
            Property(m => m.Ad).HasColumnName("Ad");
            Property(m => m.Soyad).HasColumnName("Soyad");
            Property(m => m.TamAdres).HasColumnName("TamAdres");
        }
    }
}
