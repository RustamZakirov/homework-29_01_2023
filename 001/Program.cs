// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine("введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10;
int c = b % 10;
Console.WriteLine($"второе число = {c}");