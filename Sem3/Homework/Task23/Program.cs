// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Метод для ввода данных 
double ReadData(string text)

{
    Console.Write(text);
    string? numberLine = Console.ReadLine();
    if(numberLine != null) 
    {
        double number = double.Parse(numberLine);
        return number;
    }
    return 0;
 }
 double number = ReadData("Введите число: ");


for(double i = 1; i < number; i++) //цикл выводящий все числа от 1 до n
{
    Console.Write(i + ", ");  
  
}
Console.Write(number); 

Console.WriteLine();

for(double i = 1; i < number; i++) // цикл выводяхий кубы тех чисел, которые мы нашли в предыдущем цикле
{
    double line = Math.Pow(i, 3);
    Console.Write(line + ", ");  
}
Console.Write(Math.Pow(number,3)); //вывод данных в консоль
