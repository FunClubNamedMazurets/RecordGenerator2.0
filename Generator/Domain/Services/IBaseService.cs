using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
