//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
//натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
Console.WriteLine("Введите целое число A и нажмите Enter: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B и нажмите Enter: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < B; i++)
{
result *= A;
}

Console.WriteLine("Результат возведения числа {0} в степень {1} равен {2}", A, B, result);