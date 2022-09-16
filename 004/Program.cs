// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > max)
{
    max = a;
}

Console.WriteLine("Введите третье число ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > max)
{
    max = b;
}

Console.WriteLine("Максимальное число: " + max);