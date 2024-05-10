using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модификатор_static
{
    internal class Person_2
    {
        int age;
        static int retirementAge = 65;

        //  В данном случае доступ к статической переменной retirementAge опосредуется с помощью статического свойства RetirementAge.
        public static int RetirementAge
        {
            get { return retirementAge; }
            set { if (value > 1 && value < 100) retirementAge = value; }
        }
        //  Таким образом, переменные и свойства, которые хранят состояние, общее для всех объектов класса / структуры, следует определять как статические.
        public Person_2(int age)
        {
            this.age = age;
        }
        public void СheckAge()
        {
            if (age >= retirementAge)
                Console.WriteLine("Уже на пенсии");
            else
                Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
        }
    }
}

//  Нередко статические поля и свойства применяются для хранения счетчиков.
//  Например, мы хотим иметь счетчик, который позволял бы узнать, сколько объектов Person создано:

/*
        var tom = new Person();
        var bob = new Person();
        var sam = new Person();
        Console.WriteLine(Person.Counter);  // 3
 
        class Person
        {
            static int counter = 0;
            public static int Counter => counter;
            public Person()
            {
                counter++;
            }
        }

    В данном случае в классе Person счетчик хранится в приватной переменной counter, 
    значение которой увеличивается на единицу при создании объекта в конструкторе. 

    А с помощью статического свойства Counter, которое доступно только для чтения, 
    мы можем получить значение счетчика.
 */