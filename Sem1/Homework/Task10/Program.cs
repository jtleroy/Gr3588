//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5

Console.WriteLine("Введите трехзначное число");
string? numberline = Console.ReadLine();

if (numberline != null)
{
    int number = int.Parse(numberline);
    number = number % 100;
    number = number / 10;
    Console.WriteLine(number);
}