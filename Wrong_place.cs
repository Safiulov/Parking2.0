using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTREALISE.Errors
{
    internal class Wrong_place: Exception
    {
        public Wrong_place(string message) : base(message) { }
    }
}
