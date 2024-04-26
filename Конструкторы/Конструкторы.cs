﻿// ==== Создание конструкторов ====

// Конструктор выполняет инициализацию объекта.
// При этом если в классе определяются свои конструкторы, то он лишается конструктора по умолчанию


// На уровне кода конструктор представляет метод, который называется по имени класса,
// который может иметь параметры, но для него не надо определять возвращаемый тип.

// см.класс Person

Person tom = new Person();  // Создание объекта класса Person
tom.Print();    // Имя: Tom  Возраст: 37

Console.WriteLine();

// Конструкторы могут иметь модификаторы, которые указываются перед именем конструктора.
// Так, в данном случае, чтобы конструктор был доступен вне класса Person, он определен с модификатором public

// Подобным образом мы можем определять и другие конструкторы в классе

Person_1 jam = new Person_1();          // вызов 1-ого конструктора без параметров          
Person_1 bob = new Person_1("Bob");     //вызов 2-ого конструктора с одним параметром
Person_1 sam = new Person_1("Sam", 25); // вызов 3-его конструктора с двумя параметрами

jam.Print();          // Имя: Неизвестно  Возраст: 18
bob.Print();          // Имя: Bob  Возраст: 18
sam.Print();          // Имя: Sam  Возраст: 25

// сокращенная запись:

// Person tom = new();            // аналогично new Person();
// Person bob = new("Bob");       // аналогично new Person("Bob");
// Person sam = new("Sam", 25);   // аналогично new Person("Sam", 25);