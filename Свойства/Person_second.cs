using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Свойства
{
    internal class Person_second
    {
        int age = 1;
        public int Age
        {
            set
            {
                if (value < 1 || value > 120)
                    Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
                else
                    age = value;
            }
            get { return age; }
        }
    }
}

/*
    В данном случае переменная age хранит возраст пользователя. 
    Напрямую мы не можем обратиться к этой переменной - только через свойство Age. 
    Причем в блоке set мы устанавливаем значение, если оно соответствует некоторому разумному диапазону. 
    Поэтому при передаче свойству Age значения, которое не входит в этот диапазон, значение переменной не будет изменяться:
        person.Age = -23;

    Таким образом, свойство позволяет опосредовать и контролировать доступ к данным объекта.
 */