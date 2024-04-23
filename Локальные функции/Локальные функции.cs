// Локальные функции представляют функции, определенные внутри других методов.
// Локальная функция, как правило, содержит действия, которые применяются только в рамках ее метода.

// определим метод который сравнивают сумму чисел двух массивов:

void Compare(int[] numbers1, int[] numbers2)
{
    int numbers1Sum = 0;
    int numbers2Sum = 0;

    foreach (int number in numbers1)
        numbers1Sum += number;

    foreach (int number in numbers2)
        numbers2Sum += number;

    if (numbers1Sum > numbers2Sum)
        Console.WriteLine("сумма чисел из массива numbers1 больше");
    else if (numbers1Sum < numbers2Sum)
        Console.WriteLine("сумма чисел из массива numbers2 больше");
    else
        Console.WriteLine("суммы чисел обоих массивов равны");
}

int[] numbers1 = { 1, 2, 3 };
int[] numbers2 = { 3, 4, 5, 6, 7 };

Compare(numbers1, numbers2);

// Здесь метод Compare принимает два массива и последовательно вычисляет сумму их элементов,
// чтобы узнать в каком массиве сумма чисел больше.
// Несмотря на то, что все работает, здесь есть один недостаток: здесь повторяется действия, которые вычисляют сумму массива

// а что, если мы захотим сравнивать сумму только положительных или четных чисел или как-то иначе изменить логику сравнения?
// В этом лучше вынести повторяющиеся действия в отдельный метод.
// Однако если эти действия нигде больше в прогамме не будут вызываться и будут использоваться только в одном методе,
// то целесообразно определить эти действия в виде локальной функции.
// Для этого изменим метод Compare следующим образом (Compare2):

void Compare2(int[] numbers1, int[] numbers2)
{
    int numbers1Sum = Sum(numbers1);
    int numbers2Sum = Sum(numbers2);

    if (numbers1Sum > numbers2Sum)
        Console.WriteLine("сумма чисел из массива numbers1 больше");
    else if (numbers1Sum < numbers2Sum)
        Console.WriteLine("сумма чисел из массива numbers2 больше");
    else
        Console.WriteLine("суммы чисел обоих массивов равны");

    // неважно, определена локальная функция до или после использования.
    int Sum(int[] numbers)
    {
        int result = 0;
        foreach (int number in numbers)
            result += number;
        return result;
    }
}


Compare2(numbers1, numbers2);

// Локальная функция вне ее метода не может использоваться

// ============================= Статические локальные функции

// Локальные функции могут быть статическими. Такие функции определяются с помощью ключевого слова static.
// Их особенностью является то, что они не могут обращаться к переменным окружения,
// то есть метода, в котором статическая функция определена.

int Sum(int[] numbers)
{
    int result = 0;
    int limit = 0;
    foreach (int number in numbers)
    {
        if (IsPassed(number, limit)) result += number;
    }
    return result;

    static bool IsPassed(int number, int lim)
    {
        //return number > limit; // Ошибка: метод IsPassed не имеет доступа к переменной limit
        return number > lim;
    }
}

// Модификатор static указывается перед типом локальной функции.
// Теперь функция IsPassed не может обращаться к переменной limit,
// и в этом случае нам надо либо передать это значение в виде параметра,
// либо определить переменную limit непосредственно в локальной функции.