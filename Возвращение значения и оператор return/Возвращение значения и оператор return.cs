﻿// Метод может возвращать значение, какой-либо результат.
// В предыдущих примерах были определены два метода, которые имели тип void.
// Методы с таким типом не возвращают никакого значения.
// Они просто выполняют некоторые действия.

// Но методы также могут возвращать некоторое значение.
// Для этого применяется оператор return, после которого идет возвращаемое значение:

// return возвращаемое значение;

string GetMessage()
{
    return "Hello";
}

// Методы, которые в качестве возвращаемого типа имеют любой тип, кроме void, обязательно должны использовать оператор return для возвращения значения

// Также между возвращаемым типом метода и возвращаемым значением после оператора return должно быть соответствие.
// Например: метод string а возвращаем int

// Результат методов, который возвращают значение, мы можем присвоить переменным или использовать иным образом в программе:

string message = GetMessage();  // получаем результат метода в переменную message
Console.WriteLine(message);     // Hello

// Сокращенная версия методов с результатом:
int Sum(int x, int y) => x + y;

// Оператор return не только возвращает значение, но и производит выход из метода.
// Поэтому он должен определяться после остальных инструкций.

// Однако мы можем использовать оператор return и в методах с типом void.
// В этом случае после оператора return не ставится никакого возвращаемого значения (ведь метод ничего не возвращает).
// Типичная ситуация - в зависимости от опеределенных условий произвести выход из метода:
void PrintPerson(string name, int age)
{
    if (age > 120 || age < 1)
    {
        Console.WriteLine("Недопустимый возраст");
        return;
    }
    Console.WriteLine($"Имя: {name}  Возраст: {age}");
}

PrintPerson("Tom", 37);         // Имя: Tom  Возраст: 37
PrintPerson("Dunkan", 1234);    // Недопустимый возраст