using Domain.Data.Entities;
using System.Collections.Generic;

namespace Domain.Services
{
    public interface IBaseService<T> where T : BaseEntity
    {
        T GetById(int id);

        IList<T> GetAll();

        void Insert(T entity);

        void Update(T entity);

        void Delete(int id);
    }
}
