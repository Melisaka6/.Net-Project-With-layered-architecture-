using MyProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Entities.Concrete
{
    public class Product:IEntity 
    {
        public int ProductId { get; set; }
        public string ProdutName { get; set; }
        public int  CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public Int16 UnitInStock { get; set;}

    }
}
