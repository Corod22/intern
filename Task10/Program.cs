// 10. Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число");
int threeDigitNumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра числа {threeDigitNumber}->{threeDigitNumber/10%10}");