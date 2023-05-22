// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
// int count = 1; // четные от 1
// while (count < N) 
// {
//     if (count % 2 == 0)
//     {
//         Console.WriteLine(""+count+"");
//     }
//     count++;
// }
for (int i = 2; i < N; i += 2)
{
    Console.WriteLine(" " + i + " ");
}