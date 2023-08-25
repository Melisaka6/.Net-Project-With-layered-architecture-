using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

      

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        
    

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> list = new List<Product>()
          {
              new Product{ProductId = 8 , ProdutName="Hapörler ",CategoryId = 1 ,
                 UnitPrice=15 , QuantityPerUnit = "15" , UnitInStock=245 }
          };
            return list;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
