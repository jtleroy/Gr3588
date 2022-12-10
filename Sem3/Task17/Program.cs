// Напишите рпограмму, которая принимает на вход координаты точки (X и Y), 
//причем X и Y не равны нулю и выдает номер четверти плоскости, в которой находится эта точка.
// Например: x=34; y=-30 -> 4

// Первый вариант решения задачи

// //Вводим данные координат
// Console.WriteLine("Введите координату X");
// int coordX = int.Parse( Console.ReadLine()??"0");
// Console.WriteLine("Введите координату Y");
// int coordY = int.Parse( Console.ReadLine()??"0");


// if(coordX >0 && coordY > 0) Console.WriteLine("Точка в четверти 1");
// if(coordX >0 && coordY < 0) Console.WriteLine("Точка в четверти 2");
// if(coordX <0 && coordY < 0) Console.WriteLine("Точка в четверти 3");
// if(coordX <0 && coordY > 0) Console.WriteLine("Точка в четверти 4");


// Решение задачи с помощью методов

int coordX = ReadData("Введите координату X");
int coordY = ReadData("Введите координату Y");
PrintQuterTest();

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод определяет четверть по координатам точки
void PrintQuterTest()
{
    if(coordX > 0 && coordY > 0) Console.WriteLine("Точка в четверти 1");
    if(coordX > 0 && coordY < 0) Console.WriteLine("Точка в четверти 2");
    if(coordX < 0 && coordY < 0) Console.WriteLine("Точка в четверти 3");
    if(coordX < 0 && coordY > 0) Console.WriteLine("Точка в четверти 4");
}

