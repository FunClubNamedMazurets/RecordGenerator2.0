using Domain.Data.Contexts;
using Domain.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

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
            var dodatoc2 = _reportContext.Dodatoc2s.Where(x => x.Id == id).FirstOrDefault();

            if (dodatoc2 != null)
            {
                var dynamicTable = _reportContext.DynamicTables.FirstOrDefault(x => x.EntityId == dodatoc2.Id && x.EntityTypeName == nameof(Dodatoc2));
                if (dynamicTable != null)
                {
                    dodatoc2.DynamicTable1 = dynamicTable;
                }             
            }

            return dodatoc2;
        }

        public IList<Dodatoc2> GetAll()
        {
            return _reportContext.Dodatoc2s.ToList();
        }

        public void Insert(Dodatoc2 entity)
        {
            _reportContext.Dodatoc2s.Add(entity);

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
                    EntityTypeName = nameof(Dodatoc2)
                };
                dynamicTable.SetDataRaw();

                _reportContext.DynamicTables.Add(dynamicTable);
            }
            
            _reportContext.SaveChanges();
        }

        public void Update(Dodatoc2 entity)
        {
            var dodatoc2 = _reportContext.Dodatoc2s.First(x => x.Id == entity.Id);
            if (dodatoc2 != null)
            {
                _reportContext.Entry(dodatoc2).CurrentValues.SetValues(entity);
                _reportContext.Entry(dodatoc2).State = EntityState.Modified;

                if (entity.DynamicTable1 != null)
                {
                    var dynamicTableOld = _reportContext.DynamicTables.First(x => x.EntityId == entity.Id && x.EntityTypeName == nameof(Dodatoc2));
                    if (dynamicTableOld != null)
                    {
                        var dynamicTable = new DynamicTable()
                        {
                            Id = dynamicTableOld.Id,
                            EntityId = entity.Id,
                            ColumnsCount = entity.DynamicTable1.ColumnsCount,
                            RowsCount = entity.DynamicTable1.RowsCount,
                            Data = entity.DynamicTable1.Data,
                            DataRaw = entity.DynamicTable1.Data.ToString(),
                            TableTag = entity.DynamicTable1.TableTag,
                            EntityTypeName = nameof(Dodatoc2)
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
            var dodatoc2 = _reportContext.Dodatoc2s.First(x => x.Id == id);

            if (dodatoc2 != null)
            {
                _reportContext.Dodatoc2s.Remove(dodatoc2);

                var dynamicTable = _reportContext.DynamicTables.First(x => x.EntityId == dodatoc2.Id && x.EntityTypeName == nameof(Dodatoc2));
                if (dynamicTable != null)
                {
                    _reportContext.DynamicTables.Remove(dynamicTable);
                }

                _reportContext.SaveChanges();
            }                    
        }
    }
}
