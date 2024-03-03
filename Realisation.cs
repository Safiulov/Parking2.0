using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTREALISE
{ 
    public class Realisation
    {
        public int Код { get; set; }
        public DateTime Дата_въезда { get; set; }
        public string Место { get; set; }
        public int Код_услуги { get; set; }
        public string Название_услуги { get; set; } = string.Empty;
        public int Код_клиента { get; set; }
        public string ФИО { get; set; } = string.Empty;
        public string Госномер { get; set; } = string.Empty;
        public int Стоимость { get; set; }
        public int? Сумма { get; set; }

    }
    
}
