/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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
/// Метод вычисляет функцию Аккермана с помощью рекурсии.
/// </summary>
int GetAckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0)
    {
        return GetAckermannFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return GetAckermannFunction(m - 1, GetAckermannFunction(m, n - 1));
    }
    else return n + 1;
}

Console.Clear();
int numM = InputNumbers("Введите первое неотрицательное число m: ");
int numN = InputNumbers("Введите второе неотрицательное число n: ");
if (numM < 0 || numN < 0) Console.WriteLine("\nВведены некорректные данные!");
else
{
    int ackFunc = GetAckermannFunction(numM, numN);
    Console.Write($"\tm = {numM}, n = {numN}\nВычисления функции Аккермана A(m,n) = {ackFunc}");
}