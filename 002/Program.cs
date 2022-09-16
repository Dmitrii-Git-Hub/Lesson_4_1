// "...и выдаёт, какое число большее, а какое меньшее." (Значит выдавать два числа!)

Console.WriteLine("Введите первое число");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int i = Convert.ToInt32(Console.ReadLine());

if (max > i)
{
    Console.WriteLine(max + " большее число, " + i + " меньшее число.");
}

if (max < i)
{
    Console.WriteLine(i + " большее число, " + max + " меньшее число.");
}