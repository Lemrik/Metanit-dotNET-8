class Person
{
    public string name;
    public int age;
    public Person()
    {
        Console.WriteLine("Создание объекта Person");
        name = "Tom";
        age = 37;
    }
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}