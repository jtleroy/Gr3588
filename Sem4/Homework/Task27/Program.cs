// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadData(string text)
{
    Console.Write(text);
    string? numberLine = Console.ReadLine();
    if (numberLine != null)
    {
        int number = int.Parse(numberLine);
        return number;
    }
    return 0;
}

int SumDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}


int number = ReadData("Введите число: ");
int sum = SumDigits(number);
Console.WriteLine(sum);

