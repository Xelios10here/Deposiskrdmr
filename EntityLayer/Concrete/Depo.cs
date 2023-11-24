using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Depo
    {
        [Key]
        public int? UrunID { get; set; }
        public virtual Urun Urun { get; set; }

        public int? SatilanUrunID { get; set; }
        public virtual SatilanUrun SatilanUrun { get; set; }

    }
}
