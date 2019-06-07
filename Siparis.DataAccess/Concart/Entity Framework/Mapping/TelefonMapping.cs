using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.DataAccess.Concart.Entity_Framework.Mapping
{
   public class TelefonMapping:EntityTypeConfiguration<Telefon>
    {
        public TelefonMapping()
        {
            ToTable(@"Telefon", @"dbo");

            HasKey(t => t.Musteri_ID);

            Property(t => t.Musteri_ID).HasColumnName("Musteri_ID");
            Property(t => t.TelefonNumarasi).HasColumnName("TelefonNumarasi");
        }
    }
}
