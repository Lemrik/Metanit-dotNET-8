//  Проверка на null. Null guard ======================

//  Если мы собираемся использовать переменную или параметр, которые допускают значение null,
//  то есть представляют nullable-тип (не важно значимый или ссылочный), то,
//  чтобы избежать возникновения NullReferenceException, мы можем проверить на null:

void PrintUpper(string? text)
{
    if (text != null)
    {
        Console.WriteLine(text.ToUpper());
    }
}

//  В данном случае если параметр text не равен null, то вызываем у строки метод ToUpper(),
//  который переводит символы строки в верхний регистр.

//  Кроме того, с помощью оператора is мы можем проверить значение объекта:
//      объект is значение

//  Если объект слева от оператора is имеет значение справа от оператора.
//  тогда оператор is возвращает true, иначе возвращается false

//  Например, проверка параметра/переменной на значение null:

void PrintUpper1(string? text)
{
    if (text is null) return;
    Console.WriteLine(text.ToUpper());
}

//  Или, наоборот, с помощью is not можно проверить отсутствие значения:
void PrintUpper2(string? text)
{
    if (text is not null)
        Console.WriteLine(text.ToUpper());
}

//  Также можно проверить на соответствие типу, значение которого мы собираемся использовать:
void PrintUpper3(string? text)
{
    if (text is string)
        Console.WriteLine(text.ToUpper());
    else
        Console.WriteLine("NULL");
}
//  Подобные проверки еще называются null guard или условно говоря "защита от null".


