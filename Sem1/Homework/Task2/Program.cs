// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Считываем данные с консоли
Console.WriteLine("Введите первое число");
string? number1Line = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? number2Line = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if(number1Line!=null && number2Line!=null)
{
    //Парсим введенные числа
    int number1 = int.Parse(number1Line);
    int number2 = int.Parse(number2Line);
    int max;

    // Сравниваем два числа
    if (number1>number2) 
    {
        max = number1;
    }
    else 
    {
        max = number2;
    }

    // Выводим максимальное число в консоль
    Console.WriteLine("Максимальное число равно " + max);
}
