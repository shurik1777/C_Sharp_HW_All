/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.WriteLine($"Программа даст знать сколько чисел больше 0");
Console.WriteLine();
Console.Write($"Введите сумму чисел M (КОЛИЧЕСТВО чисел): ");

int n = Convert.ToInt32(Console.ReadLine());

int count = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Введите число индекса [ {i} ] число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
}
Console.WriteLine();
Console.WriteLine("Чисел больше нуля:" + count);