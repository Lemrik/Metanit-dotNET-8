﻿// Цикл foreach предназначен для перебора набора или коллекции элементов. Его общее определение:
/*
    foreach(тип_данных переменная in коллекция)
    {
        // действия цикла
    }
*/

// После оператора foreach в скобках сначала идет определение переменной.
// Затем ключевое слово in и далее коллекция, элементы которой надо перебрать.

// При выполнении цикл последовательно перебирает элементы коллекции и помещает их в переменную
// И таким образом в блоке цикла мы можем выполнить с ними некоторые действия.

// Например, возьмем строку. Строка по сути - это коллекция символов. 
// И .NET позволяет перебрать все элементы строки - ее символы с помощью цикла foreach.

foreach (char c in "Lemrik")
{
    Console.WriteLine(c);
}

Console.WriteLine();

// Стоит отметить, что переменная, которая определяется в объявлении цикла, должна по типу соответствовать типу элементов перебираемой коллекции.
// Так, элементы строки - значения типа char - символы. Поэтому переменная c имеет тип char.
// Однако в реальности не всегда бывает очевидно, какой тип представляют элементы коллекции.
// В этом случае мы можем определить переменную с помощью оператора var

// Пример использования цикла с массивом
string[] carTypes = [ "Ford", "BMW", "Yugo", "Honda" ];
foreach (string c in carTypes)
{
    Console.WriteLine(c);
}