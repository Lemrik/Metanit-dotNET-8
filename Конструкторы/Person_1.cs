class Person_1
{
    public string name;
    public int age;

    public Person_1() { name = "Неизвестно"; age = 18; }      // 1 конструктор

    public Person_1(string n) { name = n; age = 18; }         // 2 конструктор

    public Person_1(string n, int a) { name = n; age = a; }   // 3 конструктор

    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}

// в классе определено три конструктора,
// каждый из которых принимает различное количество параметров и устанавливает значения полей класса.
// И мы можем вызвать один из этих конструкторов для создания объекта класса.