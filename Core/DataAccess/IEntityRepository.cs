using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    // Generic Constraint
    // T:class - referans tip olabilir demek
    // , IEntity = hem referans tip hem IEntity'den implemente edilen bir nesne olabilir
    // new() : new'lenebilir olmaalı (direkt olarak interface verilmesini engelliyoruz. Interfaceler new'lenemez)
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}