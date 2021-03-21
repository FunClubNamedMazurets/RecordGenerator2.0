using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class Forma7Service : IBaseService<Forma7>
    {
        private ReportContext _reportContext;

        public Forma7Service()
        {
            _reportContext = new ReportContext();
        }

        public Forma7 GetById(int id)
        {
            return _reportContext.Forma7s.Where(x => x.Id == id).First();
        }

        public IList<Forma7> GetAll()
        {
            return _reportContext.Forma7s.ToList();
        }

        public void Insert(Forma7 entity)
        {
            _reportContext.Forma7s.Add(entity);
            _reportContext.SaveChanges();
        }

        public void Update(Forma7 entity)
        {
            var forma7 = _reportContext.Forma7s.First(x => x.Id == entity.Id);
            if (forma7 != null)
            {
                _reportContext.Entry(forma7).CurrentValues.SetValues(entity);
                _reportContext.Entry(forma7).State = EntityState.Modified;
                _reportContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var forma7 = _reportContext.Forma7s.First(x => x.Id == id);

            if (forma7 != null)
            {
                _reportContext.Forma7s.Remove(forma7);
                _reportContext.SaveChanges();
            }
        }
    }
}
