using Domain.Data.Contexts;
using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class Dodatoc2Service : IBaseService<Dodatoc2>
    {
        private ReportContext _reportContext;

        public Dodatoc2Service()
        {
            _reportContext = new ReportContext();
        }

        public Dodatoc2 GetById(int id) 
        {
            return _reportContext.Dodatoc2s.Where(x => x.Id == id).First();
        }

        public IList<Dodatoc2> GetAll()
        {
            return _reportContext.Dodatoc2s.ToList();
        }

        public void Insert(Dodatoc2 entity)
        {
            _reportContext.Dodatoc2s.Add(entity);
            _reportContext.SaveChanges();
        }

        public void Update(Dodatoc2 entity)
        {
            var dodatoc2 = _reportContext.Dodatoc2s.First(x => x.Id == entity.Id);
            if (dodatoc2 != null)
            {
                dodatoc2 = entity;
                _reportContext.SaveChanges();
            }            
        }

        public void Delete(int id)
        {
            var dodatoc2 = _reportContext.Dodatoc2s.First(x => x.Id == id);

            if (dodatoc2 != null)
            {
                _reportContext.Dodatoc2s.Remove(dodatoc2);
                _reportContext.SaveChanges();
            }                    
        }
    }
}
