using MyProject.Busines.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Busines.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _Categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _Categorydal = categorydal;
        }


        public List<Category> GetAll()
        {
            return _Categorydal.GetAll();
        }
    }
}
