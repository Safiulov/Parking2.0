using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TESTREALISE
{
    public class Spaces
    {
        public string Место { get; set; }
        
        public string Статус{ get; set; } = string.Empty;
        public DateTime? Дата_въезда { get; set; }
        public string Госномер { get; set; } = string.Empty;
    }
}
