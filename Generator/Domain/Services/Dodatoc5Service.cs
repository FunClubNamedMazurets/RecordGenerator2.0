using System.Collections.Generic;
using System.Linq;
using Domain.Data.Contexts;
using Domain.Data.Entities;
using System.Data.Entity;

namespace Domain.Services
{
    public class Dodatoc5Service : IBaseService<Dodatoc5>
    {
        private ReportContext _reportContext;

        public Dodatoc5Service()
        {
            _reportContext = new ReportContext();
        }

        public Dodatoc5 GetById(int id)
        {
            return _reportContext.Dodatoc5s.Where(x => x.Id == id).FirstOrDefault();
        }

        public IList<Dodatoc5> GetAll()
        {
            return _reportContext.Dodatoc5s.ToList();
        }

        public void Insert(Dodatoc5 entity)
        {
            _reportContext.Dodatoc5s.Add(entity);
            _reportContext.SaveChanges();
        }

        public void Update(Dodatoc5 entity)
        {
            var dodatoc5 = _reportContext.Dodatoc5s.FirstOrDefault(x => x.Id == entity.Id);
            if (dodatoc5 != null)
            {
                _reportContext.Entry(dodatoc5).CurrentValues.SetValues(entity);
                _reportContext.Entry(dodatoc5).State = EntityState.Modified;
                _reportContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var dodatoc5 = _reportContext.Dodatoc5s.FirstOrDefault(x => x.Id == id);

            if (dodatoc5 != null)
            {
                _reportContext.Dodatoc5s.Remove(dodatoc5);
                _reportContext.SaveChanges();
            }
        }
    }
}
