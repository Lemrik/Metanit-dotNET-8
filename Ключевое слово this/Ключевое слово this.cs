// Ключевое слово this представляет ссылку на текущий экземпляр/объект класса.

Person sam = new("Sam", 25);
sam.Print();          // Имя: Sam  Возраст: 25

// Чтобы разграничить параметры и поля класса, к полям класса обращение идет через ключевое слово this

class Person
{
    public string name;
    public int age;
    public Person() { name = "Неизвестно"; age = 18; }
    public Person(string name) { this.name = name; age = 18; }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}

// Первая часть - this.name означает, что name - это поле текущего класса, а не название параметра name.
// Если бы у нас параметры и поля назывались по-разному, то использовать слово this было бы необязательно.
// Также через ключевое слово this можно обращаться к любому полю или методу.