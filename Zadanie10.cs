// Задание 10
Console.WriteLine(" Введите a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k");
int k = Convert.ToInt32(Console.ReadLine());

if (a % k == 0)
{
    Console.WriteLine("k делитель числа a");
}
if (b % k == 0)
{
    Console.WriteLine("k делитель числа b");
}
if (c % k == 0)
{
    Console.WriteLine("k делитель числа c");
}