using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Helpers;

namespace Domain.Data.Entities
{
    public class DynamicTable : BaseEntity
    {
        public int EntityId { get; set; }
        public int ColumnsCount { get; set; }
        public int RowsCount { get; set; }
        public string DataRaw { get; set; }
        public int TableTag { get; set; }
        public string EntityTypeName { get; set; }


        [NotMapped]
        public string[,] Data { get; set; }

        public DynamicTable()
        {
        }

        public DynamicTable(int rowsCount, int columnsCount, int tableTag)
        {
            ColumnsCount = columnsCount;
            RowsCount = rowsCount;
            Data = new string[rowsCount, columnsCount];
            TableTag = tableTag;
        }

        public void SetDataRaw()
        {
            if (Data.Length > 0)
            {
                DataRaw = string.Empty;

                for (int i = 0; i < RowsCount; i++)
                {
                    for (int j = 0; j < ColumnsCount; j++)
                    {
                        DataRaw += Data[i, j] + Constants.Splitter;
                    }
                }
            }


            if (DataRaw.EndsWith(Constants.Splitter.ToString()))
            {
                DataRaw = DataRaw.Substring(0, DataRaw.Length - 1);
            }
        }
    }
}
