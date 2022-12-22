// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

// Метод, считывающий данные, введенные пользователем
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

double b1 = ReadData("Введите значение b1: ");
double b2 = ReadData("Введите значение b2: ");
double k1 = ReadData("Введите значение k1: ");
double k2 = ReadData("Введите значение k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
Console.WriteLine();
Console.Write("(" + x + "; ");
Console.Write(y + ")");