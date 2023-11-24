using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SatilanUrun
    {
        [Key]
        public int SatilanUrunID { get; set; }
        [StringLength(50)]
        public string SatilanUrunAd { get; set; }
        public DateTime SatisTarih { get; set; }
        public int SatisAdet { get; set; }
        public decimal Fiyat { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public int MusteriID { get; set; }
        public virtual Musteri Musteri { get; set; }
        public ICollection<Urun> Uruns { get; set; }
        public ICollection<Musteri> Musteris { get; set; }
        public ICollection<Depo> Depos { get; set; }
    }
}
