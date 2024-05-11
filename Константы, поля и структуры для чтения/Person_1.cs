using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Константы__поля_и_структуры_для_чтения
{
    internal class Person_1
    {

        /*
            Поля для чтения представляют такие поля класса или структуры, 
            значение которых нельзя изменить. 
            Таким полям можно присвоить значение либо при непосредственно при их объявлении, либо в конструкторе. 
            В других местах программы присваивать значение таким полям нельзя, можно только считывать их значение.

            Поле для чтения объявляется с ключевым словом readonly:
         */

        public readonly string name = "Undefined"; // можно так инициализировать
        public Person_1(string name)
        {
            this.name = name; // в конструкторе также можно присвоить значение полю для чтения
        }
        public void ChangeName(string otherName)
        {
            //this.name = otherName;    // так нельзя 
        }
    }
}
