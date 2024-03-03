using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTREALISE
{
    public class Sales
    {
        public int Код { get; set; }
        public DateTime Дата_въезда { get; set; }
        public DateTime? Дата_выезда { get; set; }
        public int? Тариф { get; set; }
        public int? Время_стоянки{ get; set; }
        public int? Стоимость { get; set; }
        public string Место { get; set; } 
        public int Код_клиента{ get; set; }
        public string ФИО { get; set; } = string.Empty;
        public string Госномер { get; set; } = string.Empty;
    }
}
