using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.DataAccess.Concart.Entity_Framework.Mapping
{
   public class UrunMapping:EntityTypeConfiguration<Urun>
    {
        public UrunMapping()
        {
            ToTable(@"Urun", @"dbo");

            HasKey(u => u.Urun_ID);

            Property(u => u.Urun_ID).HasColumnName("Urun_ID");
            Property(u => u.Urun_Ad).HasColumnName("Urun_Ad");
            Property(u => u.Urun_Fiyat).HasColumnName("Urun_Fiyat");
            Property(u => u.Urun_Stok_Miktari).HasColumnName("Urun_Stok_Miktari");
        }
    }
}
