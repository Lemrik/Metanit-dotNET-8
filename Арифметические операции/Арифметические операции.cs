﻿int x = 5, z = 3, y = 16, result;
Console.WriteLine($"x = {x}, z = {z}, y = {y}\n");

// Бинарные арифметические операции:

result = x + z;
Console.WriteLine($"Операция сложения двух чисел:\n result = x + z = {result} \n");

result = x - z;
Console.WriteLine($"Операция вычитания двух чисел:\n result = x - z = {result} \n");

result = x * z;
Console.WriteLine($"Операция умножения двух чисел:\n result = x * z = {result} \n");

result = x / z;
Console.WriteLine($"Операция деления двух чисел:\n result = x / z = {result} \n");

// При делении стоит учитывать, что если оба операнда представляют целые числа, то результат также будет округляться до целого числа
// Для выхода из этой ситуации необходимо определять литералы или переменные, участвующие в операции, именно как типы double или float:
double result_double;
result_double = 10.0 / 3.0;
Console.WriteLine($"Полное деление:\n result_double = 10.0 / 3.0 = {result_double} \n");

result = x % z;
Console.WriteLine($"Операция получение остатка от целочисленного деления двух чисел:\n result = x % z = {result} \n");

// Унарные арифметические операции:

// Операция инкремента
// Инкремент бывает префиксным: ++x - сначала значение переменной x увеличивается на 1, а потом ее значение возвращается в качестве результата операции.
result = ++x;
Console.WriteLine($"Префиксный инкремент:\n result = ++x = {result}\n");

// И также существует постфиксный инкремент: x++ - сначала значение переменной x возвращается в качестве результата операции, а затем к нему прибавляется 1.
result = x++;
Console.WriteLine($"Постфиксный инкремент:\n result = x++ = {result}\n");

// Операция декримента - тоже самое, только с вычитанием
