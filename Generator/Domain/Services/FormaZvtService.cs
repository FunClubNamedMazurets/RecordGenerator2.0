using System.Collections.Generic;
using System.Linq;
using Domain.Data.Contexts;
using Domain.Data.Entities;
using System.Data.Entity;

namespace Domain.Services
{
    public class FormaZvtService : IBaseService<FormaZvt>
    {
        private ReportContext _reportContext;

        public FormaZvtService()
        {
            _reportContext = new ReportContext();
        }

        public FormaZvt GetById(int id)
        {
            return _reportContext.FormaZvts.Where(x => x.Id == id).FirstOrDefault();
        }

        public IList<FormaZvt> GetAll()
        {
            return _reportContext.FormaZvts.ToList();
        }

        public void Insert(FormaZvt entity)
        {
            _reportContext.FormaZvts.Add(entity);
            _reportContext.SaveChanges();
        }

        public void Update(FormaZvt entity)
        {
            var formaZvt = _reportContext.FormaZvts.FirstOrDefault(x => x.Id == entity.Id);
            if (formaZvt != null)
            {
                _reportContext.Entry(formaZvt).CurrentValues.SetValues(entity);
                _reportContext.Entry(formaZvt).State = EntityState.Modified;
                _reportContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var formaZvt = _reportContext.FormaZvts.FirstOrDefault(x => x.Id == id);

            if (formaZvt != null)
            {
                _reportContext.FormaZvts.Remove(formaZvt);
                _reportContext.SaveChanges();
            }
        }
    }
}
