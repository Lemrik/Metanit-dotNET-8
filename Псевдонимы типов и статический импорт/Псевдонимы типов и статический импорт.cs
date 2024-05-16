﻿//  Псевдонимы

//  Для различных классов и структур мы можем использовать псевдонимы.
//  Затем в программе вместо названия типа используется его псевдоним.
//  Например, для вывода строки на экран применяется метод Console.WriteLine().
//  Но теперь зададим для класса Console псевдоним:

using printer = System.Console;

printer.WriteLine("Laudate omnes gentes laudate");
printer.WriteLine("Magnificat in secula");

//  С помощью выражения using printer = System.Console указываем, что псевдонимом для класса System.Console будет имя printer.
//  Это выражение не имеет ничего общего с подключением пространств имен в начале файла, хотя и использует оператор using.
//  При этом используется полное имя класса с учетом пространства имен, в котором класс определен.
//  И далее, чтобы вывести строку, применяется выражение printer.WriteLine("Laudate omnes gentes laudate").

//  Данная возможность может применяться, когда имена классов и структур довольно длинные,
//  и мы хотим их сократить для большей лаконичности кода,
//  либо когда мы хотим иметь более выразительные на наш субъективный взгляд имена типов.

//  И еще пример. Определим класс и для него псевдоним:

/*
    using printer = System.Console;
    using User = Person;
 
    User tom = new User("Tom");
    printer.WriteLine(tom.Name);    // Tom

    class Person
    {
        public string Name { get; set; }
        public Person(string name) => Name = name;
    }
*/

//  Класс называется Person, но в программе для него используется псевдоним User.

//  Статический импорт
//  Также в C# имеется возможность импорта статической функциональности классов. Например, импортируем возможности класса Console:

//      using static System.Console;

//      WriteLine("Hello from C# 8.0");

//  Выражение using static подключает в программу все статические методы и свойства, а также константы.
//  И после этого мы можем не указывать название класса при вызове метода.

//  Подобным образом можно определять свои классы и импортировать их:

/*
    using static System.Console;
    using static Operation;
 
    WriteLine(Sum(5, 4));       // 9
    WriteLine(Subtract(5, 4));  // 1
    WriteLine(Multiply(5, 4)); // 20
 
    static class Operation
    {
        public static int Sum(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
    }
 */