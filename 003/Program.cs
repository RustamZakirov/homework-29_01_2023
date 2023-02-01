// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("введите дату");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 6 == 0 || a % 7 == 0)
    Console.WriteLine("выходной");
else
    Console.WriteLine("будний день");