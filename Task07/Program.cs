// 7. Показать числа от -N до N
Console.WriteLine("Введите число N");
int numberN=Convert.ToInt32(Console.ReadLine());
for (int i = -numberN; i <= numberN ; i++)
{
    Console.Write($"{i} ");
}
Console.Read();