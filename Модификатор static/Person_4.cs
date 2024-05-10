using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модификатор_static
{
    internal class Person_4
    {
        static int retirementAge;
        public static int RetirementAge => retirementAge;
        //  В данном случае с помощью встроенной структуры DateTime получаем текущий год.
        static Person_4()
        {
            //  Для этого используется свойство DateTime.Now.Year.если он равен 2022,
            if (DateTime.Now.Year == 2022)
                retirementAge = 65; //  устанавливаем один пенсионный возраст.
            else
                retirementAge = 67;  //  При другом значении текущего года устанавливается другое значение пенсионного возраста.
        }
    }
}
