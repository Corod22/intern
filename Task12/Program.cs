// 12. Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число");
int threeDigitNumber=Convert.ToInt32(Console.ReadLine());
int num1=threeDigitNumber%10;
int num2=threeDigitNumber/100;
int twoDigitNumber=num2*10+num1;
Console.WriteLine($"Двухзначное число {twoDigitNumber}");