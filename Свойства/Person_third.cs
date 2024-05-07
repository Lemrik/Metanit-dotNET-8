using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Свойства
{
    internal class Person_third
    {
        string firstName;
        string lastName;
        public string Name
        {
            get 
            {
                return $"{firstName} {lastName}";
            }
        }

        // конструктор
        public Person_third(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
