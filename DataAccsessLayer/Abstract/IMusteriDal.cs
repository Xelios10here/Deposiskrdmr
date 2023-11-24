using EntityLayer.Concrete;
using System;

namespace DataAccsessLayer.Abstract
{
    public interface IMusteriDal : IRepository<Musteri>
    {
        Musteri Get(Func<object, bool> value);
    }
}
