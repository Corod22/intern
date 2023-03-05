// 5. Написать программу вычисления значения функции y = f(a). у = a – 2, если a > 0,
Console.WriteLine("Введите начало a");
int aS = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите окончание a");
int aE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("функция y = f(a). у = a – 2, если a > 0. Равна");
Console.WriteLine($"    a    y");
for (int i = aS; i < aE + 1; i++)
{
    if (i > 0)
    {
        int a = i;
        int y = a - 2;
        Console.WriteLine($"{a,5}{y,5}");
    }
}
Console.ReadLine();