// Тип данных - enum или перечисление.Перечисления представляют набор логически связанных констант.

// Объявление перечисления происходит с помощью оператора enum:

//enum DayTime // Здесь определено перечисление DayTime, которое имеет четыре значения: Morning, Afternoon, Evening и Night
//{
//    Morning,
//    Afternoon,
//    Evening,
//    Night
//}

// После оператора enum идет название перечисления.
// И затем в фигурных скобках через запятую перечисляются константы перечисления


// Каждое перечисление фактически определяет новый тип данных,
// с помощью которых мы также, как и с помощью любого другого типа,
// можем определять переменные, константы, параметры методов и т.д.
// В качестве значения переменной, константы и параметра метода, которые представляют перечисление,
// должна выступать одна из констант этого перечисления, например:

//const DayTime dayTime = DayTime.Morning;
DayTime dayTime = DayTime.Morning;

if (dayTime == DayTime.Morning)
Console.WriteLine("Доброе утро");
else
Console.WriteLine("Привет");

Console.WriteLine("\n");

// ====== Хранение состояния
// Зачастую переменная перечисления выступает в качестве хранилища состояния,
// в зависимости от которого производятся некоторые действия:

DayTime now = DayTime.Evening;

PrintMessage(now);                   // Добрый вечер
PrintMessage(DayTime.Afternoon);    // Добрый день
PrintMessage(DayTime.Night);        // Доброй ночи

void PrintMessage(DayTime dayTime)
{
    switch (dayTime)
    {
        case DayTime.Morning:
            Console.WriteLine("Доброе утро");
            break;
        case DayTime.Afternoon:
            Console.WriteLine("Добрый день");
            break;
        case DayTime.Evening:
            Console.WriteLine("Добрый вечер");
            break;
        case DayTime.Night:
            Console.WriteLine("Доброй ночи");
            break;
    }
}

Console.WriteLine("\n");

// Или работа метода
DoOperation(10, 5, Operation.Add);          // 15
DoOperation(10, 5, Operation.Subtract);     // 5
DoOperation(10, 5, Operation.Multiply);     // 50
DoOperation(10, 5, Operation.Divide);       // 2

void DoOperation(double x, double y, Operation op)
{
    double result = op switch
    {
        Operation.Add => x + y,
        Operation.Subtract => x - y,
        Operation.Multiply => x * y,
        Operation.Divide => x / y
    };
    Console.WriteLine(result);
}

// ======== Тип и значения констант перечисления
// Константы перечисления могут иметь тип.
// Тип указывается после названия перечисления через двоеточие:
DayTime now1 = DayTime.Morning;

Console.WriteLine((int) now1);  // 0
Console.WriteLine((int)DayTime.Night);  // 3


// Тип перечисления обязательно должен представлять целочисленный тип
// (byte, sbyte, short, ushort, int, uint, long, ulong).
// Если тип явным образом не указан, то по умолчанию используется тип int.

// Тип влияет на значения, которые могут иметь константы.
// По умолчанию каждому элементу перечисления присваивается целочисленное значение,
// причем первый элемент будет иметь значение 0, второй - 1 и так далее.
// Например, возьмем выше определенное DayTime:

enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}

enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}

enum Time : byte
{
    Morning,
    Afternoon,
    Evening,
    Night
}

// Можно также явным образом указать значения элементов, либо указав значение первого элемента:
enum DayTime1
{
    Morning = 3,    // каждый следующий элемент по умолчанию увеличивается на единицу
    Afternoon,      // этот элемент равен 4
    Evening,        // 5
    Night           // 6
}

// Но можно и для всех элементов явным образом указать значения:
enum DayTime2
{
    Morning = 2,
    Afternoon = 4,
    Evening = 8,
    Night = 16
}

// При этом константы перечисления могут иметь одинаковые значения,
// либо даже можно присваивать одной константе значение другой константы:
enum DayTime4
{
    Morning = 1,
    Afternoon = Morning,
    Evening = 2,
    Night = 2
}