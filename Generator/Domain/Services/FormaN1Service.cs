using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class FormaN1Service : IBaseService<FormaN1>
    {
        private ReportContext _reportContext;

        public FormaN1Service()
        {
            _reportContext = new ReportContext();
        }

        public FormaN1 GetById(int id)
        {
            return _reportContext.FormaN1s.Where(x => x.Id == id).First();
        }

        public IList<FormaN1> GetAll()
        {
            return _reportContext.FormaN1s.ToList();
        }

        public void Insert(FormaN1 entity)
        {
            _reportContext.FormaN1s.Add(entity);
            _reportContext.SaveChanges();
        }

        public void Update(FormaN1 entity)
        {
            var formaN1 = _reportContext.FormaN1s.First(x => x.Id == entity.Id);
            if (formaN1 != null)
            {
                _reportContext.Entry(formaN1).CurrentValues.SetValues(entity);
                _reportContext.Entry(formaN1).State = EntityState.Modified;
                _reportContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var formaN1 = _reportContext.FormaN1s.First(x => x.Id == id);

            if (formaN1 != null)
            {
                _reportContext.FormaN1s.Remove(formaN1);
                _reportContext.SaveChanges();
            }
        }
    }
}
