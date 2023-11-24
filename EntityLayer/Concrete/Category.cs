using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(20)]
        public string CategoryAd { get; set; }
        public ICollection<Urun> Uruns { get; set; }
        public ICollection<Depo> Depos { get; set; }
    }
}
