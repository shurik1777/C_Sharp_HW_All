// Доп. задание №1:
// Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада.
//  На вход будет подаваться число (сумма вклада). При значении меньше 100, будет начислено 5 %,
//   если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. Отработав,
//   программа должна вывести общую сумму с начисленными процентами.

Console.WriteLine("Введите сумму вклада: ");
double suma = Convert.ToDouble(Console.ReadLine());
if (suma < 100)
{
    suma += suma * 0.05;
}
else if (suma <= 200)
{
    suma += suma * 0.07;
}
else
{
    suma += suma * 0.1;
}
Console.WriteLine($"По итогу сумма вклада после начисления процентов равна: {suma}");