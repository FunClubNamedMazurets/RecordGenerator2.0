using System.Collections.Generic;
using System.Linq;
using Domain.Data.Contexts;
using Domain.Data.Entities;
using System.Data.Entity;

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
            var formaNt = _reportContext.FormaNts.Where(x => x.Id == id).FirstOrDefault();

            if (formaNt != null)
            {
                var dynamicTable = _reportContext.DynamicTables.FirstOrDefault(x => x.EntityId == formaNt.Id && x.EntityTypeName == nameof(FormaNt));
                if (dynamicTable != null)
                {
                    formaNt.DynamicTable1 = dynamicTable;
                }
            }

            return formaNt;
        }

        public IList<FormaNt> GetAll()
        {
            return _reportContext.FormaNts.ToList();
        }

        public void Insert(FormaNt entity)
        {
            _reportContext.FormaNts.Add(entity);

            if (entity.DynamicTable1 != null)
            {
                _reportContext.SaveChanges();

                var dynamicTable = new DynamicTable()
                {
                    EntityId = entity.Id,
                    ColumnsCount = entity.DynamicTable1.ColumnsCount,
                    RowsCount = entity.DynamicTable1.RowsCount,
                    Data = entity.DynamicTable1.Data,
                    TableTag = entity.DynamicTable1.TableTag,
                    EntityTypeName = nameof(FormaNt)
                };
                dynamicTable.SetDataRaw();

                _reportContext.DynamicTables.Add(dynamicTable);
            }

            _reportContext.SaveChanges();
        }

        public void Update(FormaNt entity)
        {
            var formaNt = _reportContext.FormaNts.First(x => x.Id == entity.Id);
            if (formaNt != null)
            {
                _reportContext.Entry(formaNt).CurrentValues.SetValues(entity);
                _reportContext.Entry(formaNt).State = EntityState.Modified;

                if (entity.DynamicTable1 != null)
                {
                    var dynamicTableOld = _reportContext.DynamicTables.First(x => x.EntityId == entity.Id && x.EntityTypeName == nameof(FormaNt));
                    if (dynamicTableOld != null)
                    {
                        var dynamicTable = new DynamicTable()
                        {
                            Id = dynamicTableOld.Id,
                            EntityId = entity.Id,
                            ColumnsCount = entity.DynamicTable1.ColumnsCount,
                            RowsCount = entity.DynamicTable1.RowsCount,
                            DataRaw = entity.DynamicTable1.Data.ToString(),
                            TableTag = entity.DynamicTable1.TableTag,
                            EntityTypeName = nameof(FormaNt)
                        };

                        _reportContext.Entry(dynamicTableOld).CurrentValues.SetValues(dynamicTable);
                        _reportContext.Entry(dynamicTableOld).State = EntityState.Modified;
                    }
                }

                _reportContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var formaNt = _reportContext.FormaNts.First(x => x.Id == id);

            if (formaNt != null)
            {
                _reportContext.FormaNts.Remove(formaNt);

                var dynamicTable = _reportContext.DynamicTables.First(x => x.EntityId == formaNt.Id && x.EntityTypeName == nameof(FormaNt));
                if (dynamicTable != null)
                {
                    _reportContext.DynamicTables.Remove(dynamicTable);
                }

                _reportContext.SaveChanges();
            }
        }
    }
}
