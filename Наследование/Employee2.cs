using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    internal class Employee2 : Person2
    {
        public string Company { get; set; }
        public Employee2(string name, string company)
            : base(name)
        {
            Company = company;
        }
    }
}
