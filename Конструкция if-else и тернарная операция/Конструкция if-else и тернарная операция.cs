// Конструкция if/else проверяет истинность некоторого условия и в зависимости от результатов проверки выполняет определенный код.

byte number = 1;

if (number == 1) // всегда типа bool, если true то выполняется условие
{
    Console.WriteLine("number == 1 \n");
}


// Также мы можем соединить сразу несколько условий, используя логические операторы:

if (number == 1 && number != 7) 
{
    Console.WriteLine("number == 1 && number != 7 \n");
}


// При несоблюдении условия так же можно выполнять действия
// Исполльзуется else

if (number == 4) 
{
    Console.WriteLine("number == 4 \n");
}
else
{
    Console.WriteLine($"number != 4 \n");
}


// Используя конструкцию else if, мы можем обрабатывать дополнительные условия:

int num1 = 8;
int num2 = 6;
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2} \n");
}
else if (num1 < num2)
{
    Console.WriteLine($"Число {num1} меньше числа {num2} \n");
}
else
{
    Console.WriteLine("Число num1 равно числу num2 \n");
}


// При необходимости можно добавить несколько выражений else if:

string name = "Alex";

if (name == "Tom")
    Console.WriteLine("Вас зовут Tomas \n");
else if (name == "Bob")
    Console.WriteLine("Вас зовут Robert \n");
else if (name == "Mike")
    Console.WriteLine("Вас зовут Michael \n");
else
    Console.WriteLine("Неизвестное имя \n");

// Тернарную операция также позволяет проверить некоторое условие и в зависимости от его истинности выполнить некоторые действия.
// Она имеет следующий синтаксис:

// [первый операнд - условие] ? [второй операнд] : [третий операнд]

int x = 3;
int y = 2;

int z = x < y ? (x + y) : (x - y);
Console.WriteLine($"z = x < y ? (x + y) : (x - y); \nz = {z}; \n");   // 1