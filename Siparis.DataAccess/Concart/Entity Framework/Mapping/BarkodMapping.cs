using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.DataAccess.Concart.Entity_Framework.Mapping
{
    public class BarkodMapping:EntityTypeConfiguration<Barkod>
    {
        public BarkodMapping()
        {
            ToTable(@"Barkod", @"dbo");

            HasKey(b => b.Urun_ID);

            Property(b => b.Urun_ID).HasColumnName("Urun_ID");
            Property(b => b.Barkod_Numarasi).HasColumnName("Barkod_Numarasi");
        }
    }
}
