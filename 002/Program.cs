// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 100 % 10;
if (b < 1)
    Console.WriteLine("третья цияра отсутствует");
else
    Console.WriteLine($"третье число = {b}");
