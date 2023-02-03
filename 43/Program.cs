/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double k1 = GetNum("k1");
double k2 = GetNum("k2");
double b1 = GetNum("b1");
double b2 = GetNum("b2");
Console.WriteLine($"({getX(b1, b2, k1, k2)};{getY(b1, b2, k1, k2)})");

double GetNum(string Value)
{
    Console.Write($"Введите {Value} = ");
    return Convert.ToDouble(Console.ReadLine());
}

double getX(double b1, double b2, double k1, double k2)
{
    return (b2 - b1) / (k1 - k2);
} 

double getY(double b1, double b2, double k1, double k2)
{
    return k1 * (b2 - b1) / (k1 - k2) + b1;
}