// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом. Задача 19.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int number;
Console.Write("Введите пятизначное число: ");
while (!int.TryParse(Console.ReadLine(), out number))
    Console.Write("Неверный ввод!\n Введите пятизначное число: ");

int a = number / 10000;
int b = (number / 1000) % 10;
int c = (number / 10) % 10;
int d = number % 10;

if (a == d && b == c)
{
    Console.WriteLine("Число " + number + " является палиндромом");
}
else
{
    Console.WriteLine("Число " + number + " не является палиндромом");
}