using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.Entities
{
    public class Dodatoc2 : BaseEntity
    {
        //(найменування органу управління освітою, куди направляється повідомлення,  його адреса)
        public string NameOfOrgan { get; set; }

        //(прізвище, ім'я та по батькові)
        public string Initials { get; set; }

        //(навчальний заклад)
        public string EducationInstitution { get; set; }

        //(клас, група)
        public string ClassAndGroup { get; set; }

        //за  актом  форми  Н-Н N
        public string ActNumber { get; set; }
        public string ActDate { get; set; }

        //Наслідки  нещасного  випадку 
        public Grid Сonsequences { get; set; }

        //Керівник навчального закладу (ініціали, прізвище)
        public Grid BossOfInstitution { get; set; }

        //Загальна дата
        public string DateOfDocument { get; set; }

        public class Grid
        {
            //Діагноз за довідкою лікувально- профілактичного закладу
            public string Column1 { get; set; }

            //Звільнений від  навчання (відвідування) у навчальному  закладі
            public string Column2 { get; set; }

            //Число  днів невідвідування навчального закладу
            public string Column3 { get; set; }

        }
    }
}
