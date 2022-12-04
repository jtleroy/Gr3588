// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

//Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

// Прверяем, чтобы данные были не пустыми
if(num1Line != null && num2Line != null)
{
    //Парсим введенное число
    int num1=int.Parse(num1Line);
    int num2=int.Parse(num2Line);

// Проверяем, является ли первое число квадратом второго

    if (num2*num2==num1)
    {
        Console.WriteLine("Первое число квадрат второго");
    }
    else 
    {
        Console.WriteLine("Первое число НЕ квадрат второго");
    }

}