using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Busines.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        List<Product>  GetProductsByCategory(int CategoryId);
        List<Product>GetProductsByProductName(string productName);
        void Update(Product product);
    }
}
