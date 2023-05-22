/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int EntNumReq(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool LineParallel(double k1, double k2)
{
    return k1 == k2;
}

double[] CrossPoint(double k1, double b1, double k2, double b2)
{
    double X = (b2 - b1) / (k1 - k2);
    double Y = 0;
    if (k1 == 0)
    {
        Y = k2 * X + b2;
    }
    else
    {
        Y = k1 * X + b1;
    }
    double[] coordMas = new double[2];
    coordMas[0] = Math.Round(X, 2);
    coordMas[1] = Math.Round(Y, 2);

    return coordMas;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + "; ");
        else
            Console.Write(array[i]);
    }
    Console.WriteLine(")");
}

Console.WriteLine("Найдём точку пересечения двух прямых y=k1*x+b1 и y=k2*x+b2");
double b1 = EntNumReq("Введите значение коэффициента b1: ");
double k1 = EntNumReq("Введите значение коэффициента k1: ");
double b2 = EntNumReq("Введите значение коэффициента b2: ");
double k2 = EntNumReq("Введите значение коэффициента k2: ");

Console.WriteLine(LineParallel(k1, k2)
    ? "Прямые параллельны. Точек пересечения нет!"
    : "Прямые пересекаются!");

if (LineParallel(k1, k2) == false)
{
    double[] crossPoint = CrossPoint(k1, b1, k2, b2);
   
    Console.Write($"Координаты точек пересечения двух прямых по уравнению: y={k1}*x+{b1} и y={k2}*x+{b2} найдены: ");
    PrintArrayDouble(crossPoint);
}