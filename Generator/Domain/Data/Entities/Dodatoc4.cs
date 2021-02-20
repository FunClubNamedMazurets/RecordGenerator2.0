using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.Entities
{
    public class Dodatoc4 : BaseEntity
    {
        // найменування органу управління освітою, куди направляється повідомлення,  його адреса
        public string NameOfOrganAndAddress { get; set; }

        // Дата і час, коли стався нещасний випадок
        public string DateAndTime { get; set; }

        // Найменування навчального закладу,його  засновник (власник)
        public string NameOfOrganAndOwner { get; set; }

        // Місце, де  стався  нещасний випадок і його коротка характеристика 
        public string Place { get; set; }

        // Дані про   потерпілого
        public string Initials { get; set; }

        // У разі групових нещасних  випадків - характер  травм у потерпілих
        public string TypeInjuries { get; set; }

        // Обставини і можливі причини нещасного випадку
        public string CausesAccident { get; set; }

        // Дата, час передачі інформації та прізвище особи, яка передала її    
        public string DateAndSurname { get; set; }
    }
}
