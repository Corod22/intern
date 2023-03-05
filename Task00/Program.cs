// 0. Вывести квадрат числа
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
double numberSquared=Math.Pow(number, 2);
Console.WriteLine($"Квадрат числа {number} -> {numberSquared}");
