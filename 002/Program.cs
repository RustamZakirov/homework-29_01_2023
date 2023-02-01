// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a / 100 == 0 )
    Console.WriteLine("третья цифра отсутствует");
else
    Console.WriteLine($"третья цифра = {a / 100 % 10}");