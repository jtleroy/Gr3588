// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if(inputLine!=null)
{
    // Создаем массив с днями недели
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "понедельник";
    dayOfWeek[1] = "вторик";
    dayOfWeek[2] = "среда";
    dayOfWeek[3] = "четверг";
    dayOfWeek[4] = "пятница";
    dayOfWeek[5] = "суббота";
    dayOfWeek[6] = "воскресенье";

    // Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    // Находим нозвание дня недели по введенному номеру
    string outDayOfWeek = dayOfWeek[inputNumber-1];

    // Выводим данные консоли
    Console.WriteLine(outDayOfWeek);
}