// Напишите программу, которая на вход принимает число и выдает его квадрат

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

// Прверяем, чтобы данные были не пустями
if(inputLine!=null)
{
    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    //Находим квадрат числа
    //int outNumber = inputNumber*inputNumber;
    //int outNumber = (int)Math.Pow(inputNumber,2);
    
    // Выводим значение в консоль
    //Console.WriteLine(outNumber);
    Console.WriteLine(Math.Pow(int.Parse(inputLine),2));
}