/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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
/// Метод выводит сумму натуральных элементов в промежутке от M до N.
/// </summary>
int SumNaturalNumbers(int m, int n)
{
    if (m == n) return m;
    else
    {
        if (m < n) return m + SumNaturalNumbers(m + 1, n);
        else return n + SumNaturalNumbers(m, n + 1);
    }
}

Console.Clear();
int numM = InputNumbers("Введите первое натуральное число M: ");
int numN = InputNumbers("Введите второе натуральное число N: ");
if (numM <= 0 || numN <= 0) Console.WriteLine("Введено не натуральное число. Число не должно быть равно или меньше нуля!");
else
{
    int sumNaturalNumbers = SumNaturalNumbers(numM, numN);
    Console.Write($"\tM = {numM}; N = {numN} \nСумма элементов от M до N = {sumNaturalNumbers}");
}