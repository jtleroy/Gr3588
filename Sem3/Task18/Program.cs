﻿
int quter = ReadData("Введите номер четверти");
PrintAnswer(quter);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод корординаты x и y
void PrintAnswer(int num)
{
    if (num > 0 && num < 5)
    {
        if(quter == 1) Console.WriteLine("x > 0, y > 0");
        if(quter == 2) Console.WriteLine("x > 0, y < 0");
        if(quter == 3) Console.WriteLine("x < 0, y < 0");
        if(quter == 4) Console.WriteLine("x > 0, y > 0");
    }
    else 
    Console.WriteLine("Вы ввели неверное значение");
}