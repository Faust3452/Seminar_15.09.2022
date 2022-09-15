// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (n%2 == 0)
{
    do
    {
    if (i%2 == 0)
    {
        if (i == n) 
        {
            Console.Write($"{i}");
        }
        else
        {
            Console.Write($"{i}, ");
        }

    }
    i++;
    }
    while (i <= n);
}
else
{
    do
    {
    if (i%2 == 0)
    {
        if (i == (n - 1)) 
        {
            Console.Write($"{i}");
        }
        else
        {
            Console.Write($"{i}, ");
        }
    }
    i++;
    }
    while (i < n);
}
