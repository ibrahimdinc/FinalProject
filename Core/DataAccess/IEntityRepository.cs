using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // :class demek ref tip olabilir demek
    //IEntity ve IEntity iplement edebilen classlar olabilr.
    //new() new lenebilir olmalı. çünkü IEntity newlenemez yani kullanılmaması için.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
