/*
Задача 42 (необязательно): Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
int EntNumReq(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int ConvNum(int num)
{
    if (num == 0) return 0;
    int result = num % 2;
    num /= 2;
    result += ConvNum(num) * 10;
    return result;
}
int number = EntNumReq("Введите десятичное число: ");

int done = ConvNum(number);
Console.WriteLine($"Ваше число [ {number} ], в довичной системе: [ {done} ]");