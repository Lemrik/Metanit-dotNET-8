﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Наследование
{
    internal class Employee : Person
    {
        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}
