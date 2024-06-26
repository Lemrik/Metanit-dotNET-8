﻿// Для инициализации объектов классов можно применять инициализаторы.
// Инициализаторы представляют передачу в фигурных скобках значений доступным полям и свойствам объекта:


// Для инициализации объектов классов можно применять инициализаторы.
// Инициализаторы представляют передачу в фигурных скобках значений доступным полям и свойствам объекта:


Person tom = new Person { name = "Tom", age = 31 };
// или так
// Person tom = new() { name = "Tom", age = 31 };
tom.Print();          // Имя: Tom  Возраст: 31

Console.WriteLine();

// С помощью инициализатора объектов можно присваивать значения всем доступным полям и свойствам объекта в момент создания.
// При использовании инициализаторов следует учитывать следующие моменты:

// С помощью инициализатора мы можем установить значения только доступных из вне класса полей и свойств объекта.
// Например, в примере выше поля name и age имеют модификатор доступа public, поэтому они доступны из любой части программы.

// Инициализатор выполняется после конструктора, поэтому если и в конструкторе,
// и в инициализаторе устанавливаются значения одних и тех же полей и свойств,
// то значения, устанавливаемые в конструкторе, заменяются значениями из инициализатора.

// Инициализаторы удобно применять, когда поле или свойство класса представляет другой класс:
Person sam = new Person { name = "Sam", age = 28, company = { title = "Microsoft" } };
sam.Print();          // Имя: Tom  Компания: Microsoft

class Person
{
    public string name;
    public Company company;
    public int age;
    public Person()
    {
        name = "Undefined";
        company = new Company();
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}  Компания: {company.title}");
}

class Company
{
    public string title = "Unknown";
}