// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int sqr_b = b * b;
if(sqr_b == a)
{
    Console.WriteLine($"Да, {a} это квадрат числа {b}");
}
else
{
    Console.WriteLine($"Нет, {a} это не квадрат числа {b}");
}


