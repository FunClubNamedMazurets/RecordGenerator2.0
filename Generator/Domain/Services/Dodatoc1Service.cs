using Domain.Data.Contexts;
using Domain.Data.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Domain.Services
{
    public class Dodatoc1Service : IBaseService<Dodatoc1>
    {
        private ReportContext _reportContext;
        private const int tableTag1 = 3;
        private const int tableTag2 = 4;

        public Dodatoc1Service()
        {
            _reportContext = new ReportContext();
        }

        public Dodatoc1 GetById(int id)
        {
            var dodatoc1 = _reportContext.Dodatoc1s.Where(x => x.Id == id).FirstOrDefault();

            if (dodatoc1 != null)
            {
                var dynamicTable1 = _reportContext.DynamicTables.FirstOrDefault(x => x.EntityId == dodatoc1.Id && x.EntityTypeName == nameof(Dodatoc1) && x.TableTag == tableTag1);
                if (dynamicTable1 != null)
                {
                    dodatoc1.DynamicTable1 = dynamicTable1;
                }

                var dynamicTable2 = _reportContext.DynamicTables.FirstOrDefault(x => x.EntityId == dodatoc1.Id && x.EntityTypeName == nameof(Dodatoc1) && x.TableTag == tableTag2);
                if (dynamicTable2 != null)
                {
                    dodatoc1.DynamicTable2 = dynamicTable2;
                }
            }

            return dodatoc1;
        }

        public IList<Dodatoc1> GetAll()
        {
            return _reportContext.Dodatoc1s.ToList();
        }

        public void Insert(Dodatoc1 entity)
        {
            _reportContext.Dodatoc1s.Add(entity);

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
                    EntityTypeName = nameof(Dodatoc1)
                };
                dynamicTable.SetDataRaw();

                _reportContext.DynamicTables.Add(dynamicTable);
            }

            if (entity.DynamicTable2 != null)
            {
                _reportContext.SaveChanges();

                var dynamicTable = new DynamicTable()
                {
                    EntityId = entity.Id,
                    ColumnsCount = entity.DynamicTable2.ColumnsCount,
                    RowsCount = entity.DynamicTable2.RowsCount,
                    Data = entity.DynamicTable2.Data,
                    TableTag = entity.DynamicTable2.TableTag,
                    EntityTypeName = nameof(Dodatoc1)
                };
                dynamicTable.SetDataRaw();

                _reportContext.DynamicTables.Add(dynamicTable);
            }

            _reportContext.SaveChanges();
        }

        public void Update(Dodatoc1 entity)
        {
            var dodatoc1 = _reportContext.Dodatoc1s.First(x => x.Id == entity.Id);
            if (dodatoc1 != null)
            {
                _reportContext.Entry(dodatoc1).CurrentValues.SetValues(entity);
                _reportContext.Entry(dodatoc1).State = EntityState.Modified;

                if (entity.DynamicTable1 != null)
                {
                    var dynamicTableOld = _reportContext.DynamicTables.First(x => x.EntityId == entity.Id && x.EntityTypeName == nameof(Dodatoc1) && x.TableTag == tableTag1);
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
                            EntityTypeName = nameof(Dodatoc1)
                        };
                        dynamicTable.SetDataRaw();

                        _reportContext.Entry(dynamicTableOld).CurrentValues.SetValues(dynamicTable);
                        _reportContext.Entry(dynamicTableOld).State = EntityState.Modified;
                    }
                }

                if (entity.DynamicTable2 != null)
                {
                    var dynamicTableOld = _reportContext.DynamicTables.First(x => x.EntityId == entity.Id && x.EntityTypeName == nameof(Dodatoc1) && x.TableTag == tableTag2);
                    if (dynamicTableOld != null)
                    {
                        var dynamicTable = new DynamicTable()
                        {
                            Id = dynamicTableOld.Id,
                            EntityId = entity.Id,
                            ColumnsCount = entity.DynamicTable2.ColumnsCount,
                            RowsCount = entity.DynamicTable2.RowsCount,
                            Data = entity.DynamicTable2.Data,
                            DataRaw = entity.DynamicTable2.Data.ToString(),
                            TableTag = entity.DynamicTable2.TableTag,
                            EntityTypeName = nameof(Dodatoc1)
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
            var dodatoc1 = _reportContext.Dodatoc1s.First(x => x.Id == id);

            if (dodatoc1 != null)
            {
                _reportContext.Dodatoc1s.Remove(dodatoc1);

                var dynamicTable1 = _reportContext.DynamicTables.First(x => x.EntityId == dodatoc1.Id && x.EntityTypeName == nameof(Dodatoc1) && x.TableTag == tableTag1);
                if (dynamicTable1 != null)
                {
                    _reportContext.DynamicTables.Remove(dynamicTable1);
                }

                var dynamicTable2 = _reportContext.DynamicTables.First(x => x.EntityId == dodatoc1.Id && x.EntityTypeName == nameof(Dodatoc1) && x.TableTag == tableTag2);
                if (dynamicTable2 != null)
                {
                    _reportContext.DynamicTables.Remove(dynamicTable2);
                }

                _reportContext.SaveChanges();
            }
        }
    }
}
