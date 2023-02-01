Console.WriteLine("введите несколько чисел");
int a = Convert.ToInt32(Console.ReadLine());
int max = 1;
int max2 = 0;
while (a != 0)
{
    a = Convert.ToInt32(Console.ReadLine());
    if (a > max)
    {
        max2 = max;
        max = a;
    }
    else if (a > max2)
        max2 = a; 
}
Console.WriteLine($"второе максимальное число = {max2}");