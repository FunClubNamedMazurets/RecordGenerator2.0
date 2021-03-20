using Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.Entities
{
    public class Dodatoc2 : BaseEntity
    {
        public string Input_1_орган_управління_освітою { get; set; }

        public string Input_2_п_і_б { get; set; }

        public string Input_3_навчальний_заклад { get; set; }

        public string Input_4_клас_група { get; set; }

        public string Input_5_номер_акту_форми { get; set; }

        public string Input_6_число { get; set; }

        public string Input_7_місяць { get; set; }

        public string Input_8_рік { get; set; }

        public string Input_9_керівник_закладу { get; set; }

        public string Input_10_ініціали_прізвище { get; set; }

        public string Input_11_число { get; set; }

        public string Input_12_місяць { get; set; }

        public string Input_13_рік { get; set; }

        public DynamicTable DynamicTable1 { get; set; }
    }
}
