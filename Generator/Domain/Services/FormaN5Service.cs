using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class FormaN5Service : IBaseService<FormaN5>
    {
        private ReportContext _reportContext;

        public FormaN5Service()
        {
            _reportContext = new ReportContext();
        }

        public FormaN5 GetById(int id)
        {
            return _reportContext.FormaN5s.Where(x => x.Id == id).First();
        }

        public IList<FormaN5> GetAll()
        {
            return _reportContext.FormaN5s.ToList();
        }

        public void Insert(FormaN5 entity)
        {
            _reportContext.FormaN5s.Add(entity);
            _reportContext.SaveChanges();
        }

        public void Update(FormaN5 entity)
        {
            var formaN5 = _reportContext.FormaN5s.First(x => x.Id == entity.Id);
            if (formaN5 != null)
            {
                _reportContext.Entry(formaN5).CurrentValues.SetValues(entity);
                _reportContext.Entry(formaN5).State = EntityState.Modified;
                _reportContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var formaN5 = _reportContext.FormaN5s.First(x => x.Id == id);

            if (formaN5 != null)
            {
                _reportContext.FormaN5s.Remove(formaN5);
                _reportContext.SaveChanges();
            }
        }
    }
}
