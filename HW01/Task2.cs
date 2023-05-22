// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine()); // Ввели число a

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine()); // Ввели число b
int max = a;
int min = a;

if (a > max ) max = a;
if (b > max ) max = b;
if (a < min ) min = a;
if (b < min ) min = b;

Console.Write("Большее число = ");
Console.WriteLine(max);

Console.Write("Меньшее число = ");
Console.WriteLine(min);