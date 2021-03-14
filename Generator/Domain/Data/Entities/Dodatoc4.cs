using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.Entities
{
    public class Dodatoc4 : BaseEntity//, IBindingListView
    {
        // найменування органу управління освітою, куди направляється повідомлення,  його адреса
        public string Input_1_Education_Management { get; set; }

        // Дата і час, коли стався нещасний випадок
        public string Input_2_Date_Of_Accident { get; set; }

        // Найменування навчального закладу,його  засновник (власник)
        public string Input_3_Name_Of_School_And_Creator { get; set; }

        // Місце, де  стався  нещасний випадок і його коротка характеристика 
        public string Input_4_Place_Of_Accident { get; set; }

        // Дані про   потерпілого
        public string Input_5_Poor_Ones { get; set; }

        // У разі групових нещасних  випадків - характер  травм у потерпілих
        public string Input_6_Trauma { get; set; }

        // Обставини і можливі причини нещасного випадку
        public string Input_7_Reasons_Of_Accident { get; set; }

        // Дата, час передачі інформації та прізвище особи, яка передала її    
        public string Input_8_Date_And_Surname { get; set; }
    }
}
