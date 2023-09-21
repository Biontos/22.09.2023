//Задание 4
Console.WriteLine("Введите x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y");
double y = Convert.ToDouble(Console.ReadLine());
if (x == y)
    Console.WriteLine("Числа не подходят под условие");
else
    if (x > y) Console.WriteLine(x * y * 2 );
    if (x > y) Console.WriteLine((x + y) / 2);
else 
    if (x < y) Console.WriteLine((x + y) / 2);
    if (x < y) Console.WriteLine(x * y * 2);
