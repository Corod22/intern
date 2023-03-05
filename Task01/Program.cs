// 1. По двум заданным числам проверять является ли первое число квадратом второго
Console.WriteLine("Введите первое число");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int number2=Convert.ToInt32(Console.ReadLine());
double number1Squared = Math.Pow(number1, 2);
if (number1Squared==number2)
{
Console.WriteLine("Первое число является квадратом второго");
}
else
{
  Console.WriteLine("Первое число не является квадратом второго");  
}