//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Считываем данные с консоли
Console.WriteLine("Введите первое число");
string? number1Line = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? number2Line = Console.ReadLine();
Console.WriteLine("Введите третье число");
string? number3Line = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if(number1Line != null && number2Line != null && number3Line != null)
{
    // Парсим введенные числа
    int number1 = int.Parse(number1Line);
    int number2 = int.Parse(number2Line);
    int number3 = int.Parse(number3Line);

    // Проверяем, какое число является максимальным
    int max = number1;

    if(number2 > max)
    {
        max = number2;
    }

    if(number3 > max)
    {
        max = number3;
    } 

    Console.WriteLine("Максимальное число равно " + max);   
        
}