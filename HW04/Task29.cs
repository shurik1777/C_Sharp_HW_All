//Задача 29: Напишите программу, которая задаёт массив
//из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] ; 6, 1, 33 -> [6, 1, 33]
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