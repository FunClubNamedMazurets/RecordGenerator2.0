using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class FormaNpvService : IBaseService<FormaNpv>
    {
        private ReportContext _reportContext;

        public FormaNpvService()
        {
            _reportContext = new ReportContext();
        }

        public FormaNpv GetById(int id)
        {
            return _reportContext.FormaNpvs.Where(x => x.Id == id).First();
        }

        public IList<FormaNpv> GetAll()
        {
            return _reportContext.FormaNpvs.ToList();
        }

        public void Insert(FormaNpv entity)
        {
            _reportContext.FormaNpvs.Add(entity);
            _reportContext.SaveChanges();
        }

        public void Update(FormaNpv entity)
        {
            var formaNpv = _reportContext.FormaNpvs.First(x => x.Id == entity.Id);
            if (formaNpv != null)
            {
                _reportContext.Entry(formaNpv).CurrentValues.SetValues(entity);
                _reportContext.Entry(formaNpv).State = EntityState.Modified;
                _reportContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var formaNpv = _reportContext.FormaNpvs.First(x => x.Id == id);

            if (formaNpv != null)
            {
                _reportContext.FormaNpvs.Remove(formaNpv);
                _reportContext.SaveChanges();
            }
        }
    }
}
