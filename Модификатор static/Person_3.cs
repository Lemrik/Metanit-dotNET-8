using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модификатор_static
{
    internal class Person_3
    {
        public int Age { get; set; }
        static int retirementAge = 65;
        public Person_3(int age) => Age = age;

        //  В данном случае в классе Person определен статический метод CheckRetirementStatus(),
        //  который в качестве параметра принимает объект Person и проверяет его пенсионный статус.
        public static void CheckRetirementStatus(Person_3 person)
        {
            if (person.Age >= retirementAge)
                Console.WriteLine("Уже на пенсии");
            else
                Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - person.Age}");
        }
        //  Следует учитывать, что статические методы могут обращаться только к статическим членам класса.
        //  Обращаться к нестатическим методам, полям, свойствам внутри статического метода мы не можем.
    }
}
