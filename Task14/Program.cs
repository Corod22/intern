// 14. Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number>100)
{
    int num=number;
while(num>1000)
{
num=num/10;
}
int threeDigitNumber = num%10;
Console.WriteLine($"Третья цифра числа {threeDigitNumber}");
}
else Console.WriteLine("Третьей цифры нет");
