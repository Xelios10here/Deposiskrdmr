using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete
{
    public class Context: DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Depo> Depos { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<SatilanUrun> SatilanUruns { get; set; }
        public DbSet<Urun> Uruns { get; set; }
    }
}
