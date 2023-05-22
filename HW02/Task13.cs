// Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа
//  или сообщает, что третьей цифры нет.

// 78 -> третьей цифры нет

// 3267900 -> 6

// ДОП: цифра третья может быть как с левой стороны, так и с правой

Console.WriteLine("Введите целое число и нажмите Enter:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > -100 && number < 100)              // Проверка, есть ли 3я цифра
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}

else
{
    int thirdDigit = FindThirdDigit(number);
    Console.WriteLine($"Третья цифра числа {number} -> {thirdDigit}");
}

int FindThirdDigit(int number)                  // Метод по поиску 3-й цифры в числе
{
    if (number < 0) number = number * (-1);     // Если число отрицательное - делаем его положительным
    while (number > 1000)
    {
        number = number / 10;
    }

    int result = number % 10;
    return result;
}