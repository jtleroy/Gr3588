// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

//Считываем данные с консоли
string? inputeLine = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if(inputeLine!=null)
{
    //Парсим введенное число
    int inputeNumber = int.Parse(inputeLine);
    int starNumber = inputeNumber*(-1);

    // Выходное значение
    string outLine = string.Empty;

    while(starNumber<inputeNumber)
    {
        outLine = outLine + starNumber + ",";
        starNumber++;
        //starNumber=starNumber+1

    }
    outLine = outLine + inputeNumber;
    // Выводим данные в консоль
    Console.WriteLine(outLine);
}
