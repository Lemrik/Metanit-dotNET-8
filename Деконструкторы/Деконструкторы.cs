// ==== Деконструкторы ====

// Деконструкторы(не путать с деструкторами) позволяют выполнить декомпозицию (разделение целого на части) объекта на отдельные части.

// В этом случае мы могли бы выполнить декомпозицию объекта Person так:

Person person = new Person("Tom", 33);

(string name, int age) = person;

Console.WriteLine(name);    // Tom
Console.WriteLine(age);     // 33

Console.WriteLine();

// Значения переменным из деконструктора передаюся по позиции.
// То есть первое возвращаемое значение в виде параметра personName передается первой переменной - name, второе возващаемое значение - переменной age.

// По сути деконструкторы это не более, чем более удобный способ разложения объекта на компоненты.
// Это все равно, что если бы мы написали:

string name1; int age1;
person.Deconstruct(out name1, out age1);
Console.WriteLine(name1);    // Tom
Console.WriteLine(age1);     // 33

Console.WriteLine();

// При получении значений из деконструктора нам необходимо предоставить столько переменных,
// сколько деконструктор возвращает значений.
// Однако бывает, что не все эти значения нужны.
// И вместо возвращаемых значений мы можм использовать прочерк _.
// Например, нам надо получить только возраст пользователя:

(_, int age3) = person;

Console.WriteLine(age3);    // 33
// Поскольку первое возвращаемое значение - это имя пользователя,
// которое не нужно, в в данном случае вместо переменной прочерк.

class Person
{
    string name;
    int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Deconstruct(out string personName, out int personAge)
    {
        personName = name;
        personAge = age;
    }
}