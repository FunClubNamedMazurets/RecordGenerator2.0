using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Helpers
{
    public class DynamicTable
    {
        public int ColumnsCount { get; set; }
        public int RowsCount { get; set; }
        public string[,] Data { get; set; }

        public DynamicTable(int rowsCount, int columnsCount)
        {
            ColumnsCount = columnsCount;
            RowsCount = rowsCount;
            Data = new string[rowsCount, columnsCount];
        }
    }
}
