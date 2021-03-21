using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class FormaNtService : IBaseService<FormaNt>
    {
        private ReportContext _reportContext;

        public FormaNtService()
        {
            _reportContext = new ReportContext();
        }

        public FormaNt GetById(int id)
        {
            return _reportContext.FormaNts.Where(x => x.Id == id).First();
        }

        public IList<FormaNt> GetAll()
        {
            return _reportContext.FormaNts.ToList();
        }

        public void Insert(FormaNt entity)
        {
            _reportContext.FormaNts.Add(entity);
            _reportContext.SaveChanges();
        }

        public void Update(FormaNt entity)
        {
            var formaNt = _reportContext.FormaNts.First(x => x.Id == entity.Id);
            if (formaNt != null)
            {
                _reportContext.Entry(formaNt).CurrentValues.SetValues(entity);
                _reportContext.Entry(formaNt).State = EntityState.Modified;
                _reportContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var formaNt = _reportContext.FormaNts.First(x => x.Id == id);

            if (formaNt != null)
            {
                _reportContext.FormaNts.Remove(formaNt);
                _reportContext.SaveChanges();
            }
        }
    }
}
