﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        // Ürünlerin tamamı değil de belli bir kısmını getirmek için filtre vermemiz gerekir:
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        // Filter=null  'filtre vermek zorunda olmadığını açıklar'
        // Tek bir elemanı getirmek için :
        T Get(Expression<Func<T,bool>> filter); // filtre vermek zorundayız
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
                
    }
}
