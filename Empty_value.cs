using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTREALISE.Errors
{
    internal class Empty_value: Exception
    {
        public Empty_value(string message):base(message) { }
    }
}
