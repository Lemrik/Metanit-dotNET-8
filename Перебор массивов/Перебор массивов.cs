// Для перебора массивов мы можем использовать различные типы циклов.
// Например, цикл foreach:
Console.WriteLine("int[] numbers = { 1, 2, 3, 4, 5 };\n");

int[] numbers = { 1, 2, 3, 4, 5 };

Console.WriteLine("Перебор массива foreach:\n");
foreach (int i in numbers)
{
    
    Console.WriteLine($"nums[] = {i}");
}

// Подобные действия можно сделать и с помощью цикл for:
Console.WriteLine("\nПеребор массива for:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"nums[{i}] = {numbers[i]}");
}

// Цикл for более гибкий по сравнению с foreach.
// Если foreach последовательно извлекает элементы контейнера и только для чтения,
// то в цикле for мы можем перескакивать на несколько элементов вперед в зависимости от приращения счетчика,
// а также можем изменять элементы:

Console.WriteLine("\nУвеличим все элементы массива в 2 раза (numbers[i] * 2):");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"nums[{i}] = {numbers[i]} * 2 = {numbers[i] * 2}");
}

// Также можно использовать и другие виды циклов, например, while:
Console.WriteLine("\nПеребор массива while:");
int k = 0;
while (k < numbers.Length)
{
    Console.WriteLine($"nums[{k}] = {numbers[k]}");
    k++;
}