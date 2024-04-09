// Для вывода данных на консоль применяется интерполяция: перед строкой ставится знак $ и после этого мы можем вводить в строку в фигурных скобках значения переменных

//Для неявной типизации вместо названия типа данных используется ключевое слово var.
//Затем уже при компиляции компилятор сам выводит тип данных исходя из присвоенного значения.
//Так как по умолчанию все целочисленные значения рассматриваются как значения типа int, то поэтому в итоге переменная c будет иметь тип int.
//Аналогично переменной hello присваивается строка, поэтому эта переменная будет иметь тип string

// мы не можем сначала объявить неявно типизируемую переменную, а затем инициализировать
// мы не можем указать в качестве значения неявно типизируемой переменной null, так как значение null, то компилятор не сможет вывести тип данных

// Литерал default является новым средством в версии C# 7.1, которое позволяет присваивать переменной стандартное значение ее типа данных.

// Троелсен стр. 110 с#7

bool alive = true;
bool isDead = false;
Console.WriteLine($"bool - System.Boolean - Признак истинности или ложности \n {alive} \n {isDead} \n");

byte bit1 = 1;
byte bit2 = 102;
Console.WriteLine($"byte - System.Byte - хранит целое число от 0 до 255 и занимает 1 байт \n {bit1} \n {bit2} \n");

sbyte bit3 = -101;
sbyte bit4 = 102;
Console.WriteLine($"sbyte - System.SByte - хранит целое число от -128 до 127 и занимает 1 байт \n {bit3} \n {bit4} \n");

short n1 = 1;
short n2 = 102;
Console.WriteLine($"short - System.Int16 - хранит целое число от -32768 до 32767 и занимает 2 байта \n {n1} \n {n2} \n");

ushort n3 = 1;
ushort n4 = 102;
Console.WriteLine($"ushort - System.UInt16 - хранит целое число от 0 до 65535 и занимает 2 байта \n {n3} \n {n4} \n");

int a = 10;
int b = 0b101;  // бинарная форма b = 5
int c = 0xFF;   // шестнадцатеричная форма c = 255
Console.WriteLine($"int - System.Int32 - хранит целое число от -2147483648 до 2147483647 и занимает 4 байта \n {a} \n {b} \n {c} \n");

uint a1 = 10;
uint b1 = 0b101;
uint c1 = 0xFF;
Console.WriteLine($"uint - System.UInt32 - хранит целое число от 0 до 4294967295 и занимает 4 байта \n {a1} \n {b1} \n {c1} \n");

long a2 = -10;
long b2 = 0b101;
long c2 = 0xFF;
Console.WriteLine($"long - System.Int64 - хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт \n {a2} \n {b2} \n {c2} \n");

ulong a3 = 10;
ulong b3 = 0b101;
ulong c3 = 0xFF;
Console.WriteLine($"long - System.UInt64 - хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт \n {a3} \n {b3} \n {c3} \n");

float z = 3.14f;
float x = 747.3f;
Console.WriteLine($"float - System.Single - хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта \n {z} \n {x} \n");

double z1 = 3.14d;
double x1 = 443.32d;
Console.WriteLine($"double - System.Double - хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта \n {z1} \n {x1} \n");

decimal z2 = 3.13323232323212412412m;
decimal x2 = -4.312412m;
Console.WriteLine($"decimal - System.Decimal - хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт \n {z2} \n {x2} \n");

char a5 = 'A';
char b5 = '\x5A';
char c5 = '\u0420';
Console.WriteLine($"char - System.Char - хранит одиночный символ в кодировке Unicode и занимает 2 байта \n {a5} \n {b5} \n {c5} \n");

string hello = "Hello";
string word = "world";
Console.WriteLine($"string - System.String - хранит набор символов Unicode \n {hello} \n {word} \n");

object a6 = 22;
object b6 = 3.14;
object c6 = "hello code";
Console.WriteLine($"object - System.Object - может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе \n {a6} \n {b6} \n {c6} \n");

// числовые типы .NET поддерживают свойства MaxValue и MinValue, предоставляющие информацию о диапазоне значений, которые способен хранить конкретный тип.
// В дополнение к свойствам MinValue и MaxValue каждый числовой тип может определять собственные полезные члены.

Console.WriteLine($"Max of int: {int.MaxValue}");
Console.WriteLine($"Min of int: {int.MinValue} \n");

// System. Boolean не поддерживает свойства MinValue и MaxValue, но вместо них определяет свойства TrueString и FalseString (которые выдают, соответственно,строки "True" и "False").
Console.WriteLine($"bool.FalseString: {bool.FalseString}");
Console.WriteLine($"bool.TrueString: {bool.TrueString} \n");

// Помимо возможности хранения одиночного элемента символьных данных тип System.Char предлагает немало другой функциональности. Используя статические меоды
// System. Char, можно выяснять, является данный символ цифрой, буквой, знаком пунктуации или чем-то еще.

char myChar = 'a';
Console.WriteLine("char.IsDigit ( 'a') : {0}", char.IsDigit(myChar));
Console.WriteLine("char.IsLetter ( 'a ’ ) : {0}", char.IsLetter(myChar));
Console.WriteLine("char.IsWhiteSpace('Hello There’, 5): {0}", char.IsWhiteSpace("Hello There", 5));
Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
Console.WriteLine("char.IsPunctuation(’?'): {0}\n", char.IsPunctuation('?'));

// === TryParse
//когда строка может быть преобразована в запрошенный тип данных, метод TryParse ( ) возвращает true и присваивает
//разобранное значение переменной, переданной методу. В случае невозможности разбора, значения переменной присваивается стандартное значение, а метод TryParse() возвращает false.
Console.WriteLine(bool.TryParse("True", out bool _1));


// === System.DateTime и System.TimeSpan
