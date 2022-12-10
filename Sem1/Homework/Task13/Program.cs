// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// //мой вариант решения задачи
// //метод, который считывает int с консоли
// static int ReadNumber(string text) 
// {
//     Console.WriteLine(text);
//     string? numberline = Console.ReadLine();
//     if (numberline != null)
//     {
//         int number = int.Parse(numberline);
//         return number;
//     }
//     return 0;
// }

// int number = ReadNumber("Введите число");

// if (number > 99) 
// {
//     string arrayOfDigits = number.ToString(); //преобразуем int в string, чтобы пользоваться строкой как массивом
//     Console.WriteLine(arrayOfDigits[2]); //выводим данные в консоль
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет"); //выводим данные в консоль
// }

//вариант решения 2

//вводим число
Console.WriteLine("Введите число"); 
int number = int.Parse(Console.ReadLine()??"0");

// Делаем цикл, если в числе минимум три цифры
if(number>99)
{   
    //Находим количество цифр в цисле (или можно сделать циклом while, делить number/10, пока number>10, счетчик в цикле++) 
    int length = (int)Math.Log10(number) + 1; 

    int index = 0;
    int thirdDigit = number;

    // делаем деление числа на 10 (lingth-3) раз, чтобы осталось три цифры в числе
    while(index < length-3)
    {   
        thirdDigit = thirdDigit/10;
        index++;
    }

    // находим третью цифру остатком от деления на 10
    thirdDigit = thirdDigit % 10;
    // находим тертье число
    Console.Write(thirdDigit + " " + "Является третьей цифрой числа " + number);
}
else 
{
    Console.Write("третьей цифры нет");
}