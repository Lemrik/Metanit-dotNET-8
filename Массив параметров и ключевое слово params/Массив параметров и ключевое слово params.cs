// Используя ключевое слово params, мы можем передавать неопределенное количество параметров:
void Sum(params int[] numbers)
{
    int result = 0;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}

int[] nums = { 1, 2, 3, 4, 5 };
Sum(nums);
Sum(1, 2, 3, 4);
Sum(1, 2, 3);
Sum();

// Если же нам надо передать какие- то другие параметры,
// то они должны указываться до параметра с ключевм словом params
Console.WriteLine("");

void Sum2(int initialValue, params int[]  numbers)
{
    int result = initialValue;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}

Sum2(10, nums);  // число 10 - передается параметру initialValue
Sum2(1, 2, 3, 4);
Sum2(1, 2, 3);
Sum2(20);

// Массив в качестве параметра
// Также этот способ передачи параметров надо отличать от передачи массива в качестве параметра:
Console.WriteLine("");


void Sum3(int[] numbers, int initialValue)
{
    int result = initialValue;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}

Sum3(nums, 10);
// Так как метод Sum принимает в качестве параметра массив без ключевого слова params,
// то при его вызове нам обязательно надо передать в качестве первого параметра массив.
// Кроме того, в отличие от метода с параметром params после параметра-массива могут располагаться другие параметры.