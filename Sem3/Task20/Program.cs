// напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними а 2d пространстве

int x1 = ReadData("Введите кооринату x1: ");
int y1 = ReadData("Введите кооринату y1: ");
int x2 = ReadData("Введите кооринату x2: ");
int y2 = ReadData("Введите кооринату y2: ");

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// метод находит расстояние между точками на плоскости
double distanceBetweenPoints(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return distance;
}

//Метод выводыт данные пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

PrintData("Расстояние между точками: ", distanceBetweenPoints(x1, y1, x2, y2));