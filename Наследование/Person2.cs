using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    internal class Person2
    {
        public string Name { get; set; }
        public Person2(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
