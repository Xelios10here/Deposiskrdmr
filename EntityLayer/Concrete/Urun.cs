using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Urun
    {
        [Key]
        public int UrunID { get; set; }
        [StringLength(50)]
        public string UrunAd { get; set; }
        public short Stok { get; set; }
        public bool Durum { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Depo> Depos { get; set; }
    }
}
