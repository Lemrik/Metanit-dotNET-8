﻿//  В отличие от ссылочных типов переменным/параметрам значимых типов нельзя напрямую присвоить значение null.
//  Тем не менее нередко бывает удобно, чтобы переменная/параметр значимого типа могли принимать значение null.

//  Например, получаем числовое значение из базы данных, которое в бд может отсутствовать.
//  То есть, если значение в базе данных есть - получим число, если нет - то null.

//  Чтобы присвоения переменной или параметру значимого типа значения null, э
//  ти переменная/параметр значимого типа должны представлять тип nullable.
//  Для этого после названия типа указывается знак вопроса ?

using static System.Runtime.InteropServices.JavaScript.JSType;

int? val = null;
Console.WriteLine(val);

//  Здесь переменная val представляет не просто тип int, а тип int? - тип,
//  переменные/параметры которого могут принимать как значения типа int, так и значение null.
//  В данном случае мы передаем ей значение null. Но также можно передать и значение типа int:

//int? val = null;
IsNull(val);    // null
val = 22;
IsNull(val);    // 22

void IsNull(int? obj)
{
    if (obj == null) Console.WriteLine("null");
    else Console.WriteLine(obj);
}

//  Однако если переменная/параметр представляет значимый не nullable-тип, то присвоить им значение null не получится:
//      int val = null;  // ! ошибка, переменная val НЕ представляет тип nullable
Console.WriteLine();


//  Свойства Value и HasValue и метод GetValueOrDefault =============================================

//  Структура Nullable<T> имеет два свойства:

//      Value - значение объекта

//      HasValue: возвращает true, если объект хранит некоторое значение, и false, если объект равен null.

//  Мы можем использовать эти свойства для проверки наличия и получения значения:

PrintNullable(5);       // 5
PrintNullable(null);    // параметр равен null

void PrintNullable(int? number)
{
    if (number.HasValue)
    {
        Console.WriteLine(number.Value);
        // аналогично
        Console.WriteLine(number);
    }
    else
    {
        Console.WriteLine("параметр равен null");
    }
}

//  Однако если мы попробуем получить через свойство Value значение переменной,
//  которая равна null, то мы столкнемся с ошибкой:

//  int? number = null;
//  Console.WriteLine(number.Value);    // ! Ошибка
//  Console.WriteLine(number);          // Ошибки нет - просто ничего не выведет


//  Также структура Nullable<T> имеет метод GetValueOrDefault().
//  Он возвращает значение переменной/параметра, если они не равны null.
//  Если они равны null, то возвращается значение по умолчанию.
//  Значение по умолчанию можно передать в метод.
//  Если в метод не передается данных, то возвращается значение по умолчанию для данного типа данных (например, для числовых данных это число 0).

int? number = null; // если значения нет, метод возвращает значение по умолчанию

Console.WriteLine(number.GetValueOrDefault());      // 0  - значение по умолчанию для числовых типов
Console.WriteLine(number.GetValueOrDefault(10));    // 10

number = 15;    // если значение задано, оно возвращается методом
Console.WriteLine(number.GetValueOrDefault());    // 15
Console.WriteLine(number.GetValueOrDefault(10));  // 15


//  Операции с nullable-типами

//  nullable-типы поддерживают тот же набор операций, что и их не-nullable двойники.
//  Но следует учитывать, что если в операции участвует nullable-тип, то результатом также будет значение nullable-типа