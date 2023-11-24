using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }
        [StringLength(50)]
        public string MusteriAd { get; set; }
        [StringLength(50)]
        public string MusteriSoyad { get; set; }
        [StringLength(50)]
        public string MusteriMail { get; set; }
        [StringLength(50)]
        public string MusteriFirma { get; set; }
        public int SatilanUrunID { get; set; }
        public virtual SatilanUrun SatilanUrun { get; set; }

    }
}
