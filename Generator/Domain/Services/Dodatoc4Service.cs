using Domain.Data.Contexts;
using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class Dodatoc4Service : IBaseService<Dodatoc4>
    {
        private ReportContext _reportContext;

        public Dodatoc4Service()
        {
            _reportContext = new ReportContext();
        }

        public void Delete(int id)
        {
            var dodatoc4 = _reportContext.Dodatoc4s.First(x => x.Id == id);

            if (dodatoc4 != null)
            {
                _reportContext.Dodatoc4s.Remove(dodatoc4);
                _reportContext.SaveChanges();
            }
        }

        public IList<Dodatoc4> GetAll()
        {
            return _reportContext.Dodatoc4s.ToList();
        }

        public Dodatoc4 GetById(int id)
        {
            return _reportContext.Dodatoc4s.Where(x => x.Id == id).First();
        }

        public void Insert(Dodatoc4 entity)
        {
            _reportContext.Dodatoc4s.Add(entity);
            _reportContext.SaveChanges();
        }

        public void Update(Dodatoc4 entity)
        {
            var dodatoc4 = _reportContext.Dodatoc4s.First(x => x.Id == entity.Id);
            if (dodatoc4 != null)
            {
                dodatoc4 = entity;
                _reportContext.SaveChanges();
            }
        }
    }
}
