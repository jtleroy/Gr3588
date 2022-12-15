// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadData(string text)
{
    Console.Write(text);
    string? numberLine = Console.ReadLine();
    if (numberLine != null)
    {
        int number = int.Parse(numberLine);
        return number;
    }
    return 0;
}

int length = ReadData("Введите длину массива: ");
int min = ReadData("Введите минимальное число: ");
int max = ReadData("Введите максмальное число: ");


Random rnd = new Random();
int a = rnd.Next(min, max);

int [] array = new int [length];

for(int i=0; i < length; i++)
{
    array[i] = rnd.Next(min, max);
}

for(int i=0; i < length; i++)
{
    Console.Write(array[i] + " ");
}