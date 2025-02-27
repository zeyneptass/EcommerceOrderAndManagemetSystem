﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // Generic Constraint
    // T:class : referans tip olmalı
    // IEntity : T IEntity olmalı ya da IEntity'den implemente edilen bir nesne olmalı
    // new() : new'lenenbilir olmalı (IEntity soyut nesne olduğundan new'lenemez) Soyut nesneleri yazmamızı engellemek için ekledik.
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        // Ürünlerin tamamı değil de belli bir kısmını getirmek için filtre vermemiz gerekir:
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        // Filter=null  'filtre vermek zorunda olmadığını açıklar'
        // Tek bir elemanı getirmek için :
        Task<T> GetAsync(Expression<Func<T, bool>> filter); // filtre vermek zorundayız
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);

    }
}
