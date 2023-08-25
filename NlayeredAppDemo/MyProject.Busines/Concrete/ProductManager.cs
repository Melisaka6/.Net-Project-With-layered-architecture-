using MyProject.Busines.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.DataAccess.Concrete;
using MyProject.DataAccess.Concrete.EntityFramework;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Busines.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
           _productDal = productDal;
        }

        public void Add(Product product)
        {
         _productDal.Add(product);
        }

        public void Delete(Product product)
        {
           _productDal.Delete(product);
        }

        public List<Product>GetAll()
        {
            //Business code 
            
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int CategoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == CategoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
           return _productDal.GetAll(p=>p.ProdutName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        { 
            _productDal.Update(product);
        }
    }
}
