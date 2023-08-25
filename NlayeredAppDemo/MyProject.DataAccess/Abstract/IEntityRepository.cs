using MyProject.Entities.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class , IEntity , new() 
                                        //T bir referans tip olmalı , IEntityden implemente edilmeli , newlenebilir olmalı 
    {
        List<T> GetAll(Expression <Func<T,bool >> filter=null); //Ben sana T vericem Bana bir dönüş türü olarak bool vericeksin ve buna filter diyeceğim.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
