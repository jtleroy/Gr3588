// Задача 7. Напишите программу, которая принимает на вход трехзначное число и нвыходе показывает последнюю цифру этого числа.

string? inputLine = Console.ReadLine();

if (inputLine!=null)
{
    int inputNumber = int.Parse(inputLine);

    int lastDigit = inputNumber % 10;

    Console.WriteLine(lastDigit);
}

