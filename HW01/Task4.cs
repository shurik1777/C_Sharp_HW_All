// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine()); // Ввели число a

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine()); // Ввели число b

Console.Write("Введите число b: ");
int c = Convert.ToInt32(Console.ReadLine()); // Ввели число c

int max = a;

if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;

Console.Write("Максимальное из 3х чисел = ");
Console.WriteLine(max);