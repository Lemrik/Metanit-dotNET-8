// Конструкция switch/case оценивает некоторое выражение и сравнивает его значение с набором значений.
// И при совпадении значений выполняет определенный код.

// После ключевого слова switch в скобках идет сравниваемое выражение.
// Значение этого выражения последовательно сравнивается со значениями, помещенными после оператора сase.
// И если совпадение будет найдено, то будет выполняться определенный блок сase.

// В конце каждого блока сase должен ставиться один из операторов перехода:
// break, goto case, return или throw.
// Как правило, используется оператор break. При его применении другие блоки case выполняться не будут.
string name = "Tom";

switch (name)
{
    case "Bob":
        Console.WriteLine("Ваше имя - Bob");
        break;
    case "Tom":
        Console.WriteLine("Ваше имя - Tom");
        break;
    case "Jam":
        Console.WriteLine("Ваше имя - Tom");
        break;
    case "Sam":
        Console.WriteLine("Ваше имя - Sam");
        goto case "Lemrik"; // если мы хотим, чтобы после выполнения текущего блока case выполнялся другой блок case, используем goto case
    case "Lemrik":
        Console.WriteLine("Ваше имя - Lemrik");
        break;
    default: // если ни одно значение не совпадет, выполнится блок default
        Console.WriteLine("Неизвестное имя");
        break;
}
Console.WriteLine("\n");

// Конструкция switch позволяет возвращать некоторое значение.
// Для возвращения значения в блоках case может применятся оператор return. 
int DoOperation(int op, int a, int b)
{
    switch (op)
    {
        case 1: return a + b;
        case 2: return a - b;
        case 3: return a * b;
        default: return 0;
    }
}
Console.WriteLine(DoOperation(1, 4, 8));
Console.WriteLine("\n");

// Хотя конструкция switch в примере выше прекрасно работает,
// тем не менее мы ее можем сократить и получить результат неосредственно из конструкции switch
int DoOperation1(int op, int a, int b)
{
    int result = op switch
    {
        1 => a + b,
        2 => a - b,
        3 => a * b,
        _ => 0
    };
    return result;
}

// Теперь не требуется оператор case, а после сравниваемого значения ставится оператор стрелка =>.
// Значение справа от стрелки выступает в качестве возвращаемоего значения.
// Кроме того, вместо оператора default используется почерк _.
// В итоге результат конструкции switch будет присвиваиваться переменной result.


// Можно сразу возвратить из метода результат без присвоения переменной результата конструкции switch:
int DoOperation3(int op, int a, int b)
{
    return op switch
    {
        1 => a + b,
        2 => a - b,
        3 => a * b,
        _ => 0
    };
}

// Существует и более короткая запись:
int DoOperation4(int op, int a, int b) => op switch
{
    1 => a + b,
    2 => a - b,
    3 => a * b,
    _ => 0
};