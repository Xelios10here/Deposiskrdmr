using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface ICategoryDal: IRepository<Category>
    {
        //List<Category> GetList();
        //void CategoryAdd(Category category);
        //Category GetByID(int id);
        //yukarıdaki koda bakılcak
    }
}
