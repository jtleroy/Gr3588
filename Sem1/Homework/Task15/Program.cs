// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

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

if (number <= 7 && number > 0)
{
    if (number <= 5)
    {
        Console.WriteLine("нет");
    }
    else
    {
        Console.WriteLine("да");
    }
}
else
{
    Console.WriteLine("Вы ввели неверное значение");
}