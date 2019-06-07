using Siparis.Core.Entities;
using Siparis.DataAccess.Concart.Entity_Framework.Mapping;
using Siparis.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis.DataAccess.Concart.Entity_Framework
{
   public class SiparisContext:DbContext
    {
        public SiparisContext()
        {
            Database.SetInitializer<SiparisContext>(null);
        }


        private DbSet<Musteri> Musteriler{ get; set; }
        private DbSet<Telefon> Telefonlar { get; set; }
        private DbSet<Urun> Urunler {get; set; }
        private DbSet<_Siparis> Siparisler { get; set; }
        private DbSet<Barkod> Barkodlar { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MusteriMapping());
            modelBuilder.Configurations.Add(new UrunMapping());
            modelBuilder.Configurations.Add(new TelefonMapping());
            modelBuilder.Configurations.Add(new BarkodMapping());
            modelBuilder.Configurations.Add(new SiparisMapping());

            //modelBuilder.Entity<Musteri>().HasMany<Urun>(u => u.Urunler)
                //7.WithMany(m => m.Musteriler).Map(mu =>
                //{
                    //mu.MapLeftKey("Musteri_ID");
                    //mu.MapRightKey("Urun_ID");
                    //mu.ToTable("_Siparis");
                //});

            
        }


    }
}
