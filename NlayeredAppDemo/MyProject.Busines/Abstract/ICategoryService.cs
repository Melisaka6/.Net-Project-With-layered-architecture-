 using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Busines.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

    }
}
