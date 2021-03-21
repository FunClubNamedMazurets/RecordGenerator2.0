using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class Dodatoc1Service : IBaseService<Dodatoc1>
    {
        private ReportContext _reportContext;

        public Dodatoc1Service()
        {
            _reportContext = new ReportContext();
        }

        public Dodatoc1 GetById(int id)
        {
            return _reportContext.Dodatoc1s.Where(x => x.Id == id).First();
        }

        public IList<Dodatoc1> GetAll()
        {
            return _reportContext.Dodatoc1s.ToList();
        }

        public void Insert(Dodatoc1 entity)
        {
            _reportContext.Dodatoc1s.Add(entity);
            _reportContext.SaveChanges();
        }

        public void Update(Dodatoc1 entity)
        {
            var dodatoc1 = _reportContext.Dodatoc1s.First(x => x.Id == entity.Id);
            if (dodatoc1 != null)
            {
                _reportContext.Entry(dodatoc1).CurrentValues.SetValues(entity);
                _reportContext.Entry(dodatoc1).State = EntityState.Modified;
                _reportContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var dodatoc1 = _reportContext.Dodatoc1s.First(x => x.Id == id);

            if (dodatoc1 != null)
            {
                _reportContext.Dodatoc1s.Remove(dodatoc1);
                _reportContext.SaveChanges();
            }
        }
    }
}
