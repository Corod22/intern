// 9. Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное чисо");
int threeDigitNumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Последняя цифра числа {threeDigitNumber}-> {threeDigitNumber%10}");
