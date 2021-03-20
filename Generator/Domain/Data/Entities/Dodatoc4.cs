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
        public string Input_1_орган_управління_освітою { get; set; }

        // Дата і час, коли стався нещасний випадок
        public string Input_2_дата_час_нещасності { get; set; }

        // Найменування навчального закладу,його  засновник (власник)
        public string Input_3_назва_навчального_закладу { get; set; }

        // Місце, де  стався  нещасний випадок і його коротка характеристика 
        public string Input_4_місце_нещасності { get; set; }

        // Дані про   потерпілого
        public string Input_5_дані_потерпілих { get; set; }

        // У разі групових нещасних  випадків - характер  травм у потерпілих
        public string Input_6_характер_травм { get; set; }

        // Обставини і можливі причини нещасного випадку
        public string Input_7_обставини_нещасності { get; set; }

        // Дата, час передачі інформації та прізвище особи, яка передала її    
        public string Input_8_дата_передачі_інформації { get; set; }
    }
}
