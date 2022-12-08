// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

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

if (number > 99)
{
    string arrayOfDigits = number.ToString();
    Console.WriteLine(arrayOfDigits[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

