// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// //является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // 1 -> нет

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

// if (number <= 7 && number > 0) //проверяем, чтобы число в диапазоне от 0 до 8
// {
//     if (number <= 5)
//     {
//         Console.WriteLine("нет"); //выводим данные в консоль
//     }
//     else
//     {
//         Console.WriteLine("да"); //выводим данные в консоль
//     }
// }
// else
// {
//     Console.WriteLine("Вы ввели неверное значение"); //выводим данные в консоль
// }

// Второй вариант решения задачи

// вводим число
Console.Write("Введите день недели:");
int number = int.Parse(Console.ReadLine()??"0");

//делаем цикл, если выполняется условияе 0<number<8
if((number>0)&&(number<8))
{
    // заполняем словарь
    Dictionary<int, string> dict = new Dictionary<int, string>
    {
        {1, "рабочий день"},
        {2, "рабочий день"},
        {3, "рабочий день"},
        {4, "рабочий день"},
        {5, "рабочий день"},
        {6, "выходной день"},
        {7, "выходной день"},
    };

// выводим значение словаря по дню
Console.WriteLine(dict[number]);

}
else
{
    // выводим, если не выполняется уловие
    Console.WriteLine("Это не день недели");
}