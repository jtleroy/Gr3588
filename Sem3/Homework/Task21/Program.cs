// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Метод для ввода значений координат
double ReadData(string text)

{
    Console.Write(text);
    string? coordLine = Console.ReadLine();
    if(coordLine != null) 
    {
        double coord = double.Parse(coordLine);
        return coord;
    }
    return 0;
 }

 double x1 = ReadData("Введите значение координаты x1: ");
 double y1 = ReadData("Введите значение координаты y1: ");
 double z1 = ReadData("Введите значение координаты z1: ");
 double x2 = ReadData("Введите значение координаты x2: ");
 double y2 = ReadData("Введите значение координаты y2: ");
 double z2 = ReadData("Введите значение координаты z2: ");
 
double distance = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2 - y1)*(y2-y1)+(z2-z1)*(z2-z1)); //определяет расстояние между точками 
Console.WriteLine("Расстояние между двумя точками в пространстве = " + distance); // выводит расстояние в консоли