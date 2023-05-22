/*
Задача 64: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/// <summary>
/// Проверка на числа.
/// </summary>
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
/// <summary>
/// Метод печатает все натуральные числа в промежутке от N до 1.
/// </summary>
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start - 1, end));
}

Console.Clear();
int number = InputNumbers("Введите натуральное число: ");
if (number <= 0) Console.WriteLine("Введено не натуральное число. Число не должно быть равно или меньше нуля!");
else
{
    Console.WriteLine(PrintNumbers(number, 1));
}