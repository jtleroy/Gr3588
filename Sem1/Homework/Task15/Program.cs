// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//метод, который считывает int с консоли
static int ReadNumber(string text)
{
    Console.WriteLine(text);
    string? numberline = Console.ReadLine();
    if (numberline != null)
    {
        int number = int.Parse(numberline);
        return number;
    }
    return 0;
}

int number = ReadNumber("Введите число"); 

if (number <= 7 && number > 0) //проверяем, чтобы число в диапазоне от 0 до 8
{
    if (number <= 5)
    {
        Console.WriteLine("нет"); //выводим данные в консоль
    }
    else
    {
        Console.WriteLine("да"); //выводим данные в консоль
    }
}
else
{
    Console.WriteLine("Вы ввели неверное значение"); //выводим данные в консоль
}