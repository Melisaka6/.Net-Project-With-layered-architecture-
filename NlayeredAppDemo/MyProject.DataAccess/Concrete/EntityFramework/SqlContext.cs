using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.Concrete.EntityFramework
{
    public class SqlContext:DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public  DbSet<Category> Categories { get; set; }

    }
}
