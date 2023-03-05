// 2. Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите первое число");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int number2=Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine($"Большее число {number1} - меньшее число {number2}");
}
else
{
 Console.WriteLine($"Большее число {number2} - меньшее число {number1}");  
}
Console.Read();