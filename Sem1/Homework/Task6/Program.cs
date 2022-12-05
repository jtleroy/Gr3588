//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число");
string? numberLine = Console.ReadLine();

if(numberLine != null)
{
    int number = int.Parse(numberLine);

    if(number % 2 == 0)
    {
        Console.WriteLine("Число является четным");
    }
    else 
    {
        Console.WriteLine("Число является нечетным");
    }
}