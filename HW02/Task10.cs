// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    int second = FindSecondDigit(number);
    Console.WriteLine($"Вторая цифра трехзначного числа -> {second}");
}
else Console.WriteLine("Введено не трехзначное число!");
// Метод для поиска 2й цифры трехзначного числа:
int FindSecondDigit(int number)
{
    return (number / 10 % 10);
}