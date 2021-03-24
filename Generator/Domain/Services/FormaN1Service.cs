using System.Collections.Generic;
using System.Linq;
using Domain.Data.Contexts;
using Domain.Data.Entities;
using System.Data.Entity;

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
            var formaN1 = _reportContext.FormaN1s.Where(x => x.Id == id).FirstOrDefault();

            if (formaN1 != null)
            {
                var dynamicTable = _reportContext.DynamicTables.FirstOrDefault(x => x.EntityId == formaN1.Id && x.EntityTypeName == nameof(FormaN1));
                if (dynamicTable != null)
                {
                    formaN1.DynamicTable1 = dynamicTable;
                }
            }

            return formaN1;
        }

        public IList<FormaN1> GetAll()
        {
            return _reportContext.FormaN1s.ToList();
        }

        public void Insert(FormaN1 entity)
        {
            _reportContext.FormaN1s.Add(entity);

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
                    EntityTypeName = nameof(FormaN1)
                };
                dynamicTable.SetDataRaw();

                _reportContext.DynamicTables.Add(dynamicTable);
            }

            _reportContext.SaveChanges();
        }

        public void Update(FormaN1 entity)
        {
            var formaN1 = _reportContext.FormaN1s.First(x => x.Id == entity.Id);
            if (formaN1 != null)
            {
                _reportContext.Entry(formaN1).CurrentValues.SetValues(entity);
                _reportContext.Entry(formaN1).State = EntityState.Modified;

                if (entity.DynamicTable1 != null)
                {
                    var dynamicTableOld = _reportContext.DynamicTables.First(x => x.EntityId == entity.Id && x.EntityTypeName == nameof(FormaN1));
                    if (dynamicTableOld != null)
                    {
                        var dynamicTable = new DynamicTable()
                        {
                            EntityId = entity.Id,
                            ColumnsCount = entity.DynamicTable1.ColumnsCount,
                            RowsCount = entity.DynamicTable1.RowsCount,
                            Data = entity.DynamicTable1.Data,
                            DataRaw = entity.DynamicTable1.Data.ToString(),
                            TableTag = entity.DynamicTable1.TableTag,
                            EntityTypeName = nameof(FormaN1)
                        }; 
                        dynamicTable.SetDataRaw();

                        _reportContext.Entry(dynamicTableOld).CurrentValues.SetValues(dynamicTable);
                        _reportContext.Entry(dynamicTableOld).State = EntityState.Modified;
                    }
                }

                _reportContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var formaN1 = _reportContext.FormaN1s.First(x => x.Id == id);

            if (formaN1 != null)
            {
                _reportContext.FormaN1s.Remove(formaN1);

                var dynamicTable = _reportContext.DynamicTables.First(x => x.EntityId == formaN1.Id && x.EntityTypeName == nameof(FormaN1));
                if (dynamicTable != null)
                {
                    _reportContext.DynamicTables.Remove(dynamicTable);
                }

                _reportContext.SaveChanges();
            }
        }
    }
}
