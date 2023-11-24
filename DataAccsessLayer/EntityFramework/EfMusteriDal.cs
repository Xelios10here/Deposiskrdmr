using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfMusteriDal : GenericRepository<Musteri>, IMusteriDal
    {
        public Musteri Get(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
