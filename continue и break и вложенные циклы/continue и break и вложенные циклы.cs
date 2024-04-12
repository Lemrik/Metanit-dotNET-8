// Иногда возникает ситуация, когда требуется выйти из цикла, не дожидаясь его завершения.
// В этом случае мы можем воспользоваться оператором break.

Console.WriteLine("Пример break:\n");

// Пример break:
for (int i = 0; i < 9; i++)
{
    if (i == 5)
        break;
    Console.WriteLine($"i = {i}");
}

Console.WriteLine("\nПример continue:\n");

//А что если мы хотим, чтобы при проверке цикл не завершался, а просто пропускал текущую итерацию.
//Для этого мы можем воспользоваться оператором continue:

// Пример continue:
for (int i = 0; i < 9; i++)
{
    if (i == 5)
        continue;
    Console.WriteLine($"i = {i}");
}

// операторы break и continue можно применять в любом типе циклов

Console.WriteLine("\nВложенные циклы:\n");

// Вложенные циклы
// Одни циклы могут быть вложенными в другие. Например:

for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
}