// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число проверки");
int numberCheck = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите заданное число");
int givenNumber=Convert.ToInt32(Console.ReadLine());
if (numberCheck%givenNumber!=0) Console.WriteLine($"Остаток числа {numberCheck%givenNumber}");
