// Найти количество положительных чисел в массиве:

// С помощью цикла for:
int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
int j = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        j++;
    }
}
Console.WriteLine($"Количество положительных чисел в массиве numbers = {j} (for)\n");

// С помощью цикла foreach
j = 0;
foreach (int i in numbers)
{
    if (i > 0)
    {
        j++;
    }
}
Console.WriteLine($"Количество положительных чисел в массиве numbers = {j} (foreach)\n");



// Инверсия массива:
Console.WriteLine($"Инверсия массива: int[] numbers2 = {{ -4, -3, -2, -1, 0, 1, 2, 3, 4 }};\n");
int[] numbers2 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
int n = numbers2.Length / 2;
for (int i = 0, k = 0; i < n; i++)
{
    k = numbers2[i];
    numbers2[i] = numbers2[numbers2.Length - 1 - i];
    numbers2[numbers2.Length - 1 - i] = k;
}

foreach (int i in numbers2)
{
    Console.WriteLine(i);

}


// Программа сортировки массива:
int[] numbers3 = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
int temp;
for (int i = 0; i < numbers3.Length - 1; i++)
{
    for (int s = i + 1; s < numbers3.Length; s++)
    {
        if (numbers3[i] > numbers3[s])
        {
            temp = numbers3[i];
            numbers3[i] = numbers3[s];
            numbers3[s] = temp;
        }
    }
}

// вывод
Console.WriteLine("\nВывод отсортированного массива: int[] numbers3 = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };\n");
for (int i = 0; i < numbers3.Length; i++)
{
    Console.WriteLine(numbers3[i]);
}
