// Чтобы динамически выводить сообщение с помощью метода,
// можно передавать в него желаемое сообщение.
// Для этого в языке C# мы можем использовать параметры.

// Параметры позволяют передать в метод некоторые входные данные.
// Параметры определяются через заятую в скобках после названия метода в виде:

/*
    тип_метода имя_метода(тип_параметра1 параметр1, тип_параметра2 параметр2, ...)
    {
        // действия метода
    }
 */

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

PrintMessage("Hello work");           // Hello work
PrintMessage("Hello METANIT.COM");    // Hello METANIT.COM
PrintMessage("Hello C#");             // Hello C#

Console.Write("\nВведите сообщение: ");
PrintMessage(Console.ReadLine());

Console.WriteLine("\n");

// метод, который складывает два числа:
void Sum(int x, int y)
{
    int result = x + y;
    Console.WriteLine($"{x} + {y} = {result}");
}

Sum(10, 15);    // 10 + 15 = 25

Console.WriteLine("\n");

// Если параметрами метода передаются значения переменных, то таким переменным должно быть присвоено значение.
// Например, следующая программа не скомпилируется:

void Sum2(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

int a;
int b = 15;
// Sum2(a, b);  // ! Ошибка

// При передаче значений параметрам важно учитывать тип параметров: между аргументами и параметрами должно быть соответствие по типу.
// Например:

void PrintPerson(string name, int age)
{
    Console.WriteLine($"Name: {name}  Age: {age}");
}

PrintPerson("Tom", 24); // Name: Tom  Age: 24

// Также мы можем передать параметрам значения тех типов, которые автоматически могут быть преобразованы в тип параметров.



// Данные других типов мы передать параметров не можем.
// Например, следующий вызов метода PrintPerson будет ошибочным:

// PrintPerson(45, "Bob"); // Ошибка! несоответствие значений типам параметров

Console.WriteLine("Необязательные параметры\n");

// По умолчанию при вызове метода необходимо предоставить значения для всех его параметров.
// Но C# также позволяет использовать необязательные параметры.
// Для таких параметров нам необходимо объявить значение по умолчанию.
// Также следует учитывать, что после необязательных параметров все последующие параметры также должны быть необязательными:

void PrintPerson1(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPerson1("Tom", 37, "Microsoft");  // Name: Tom  Age: 37  Company: Microsoft
PrintPerson1("Tom", 37);               // Name: Tom  Age: 37  Company: Undefined
PrintPerson1("Tom");

Console.WriteLine("\nИменованные параметры\n");

// Можно нарушить порядок передачи параметров, используя именнованные параметры:

void PrintPerson2(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPerson2("Tom", company: "Microsoft", age: 37);  // Name: Tom  Age: 37  Company: Microsoft
PrintPerson2(age: 41, name: "Bob");          // Name: Bob  Age: 41  Company: Undefined
PrintPerson2(company: "Google", name: "Sam"); // Name: Sam  Age: 1   Company: Google
