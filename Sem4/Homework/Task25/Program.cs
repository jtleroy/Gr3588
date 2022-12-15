// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

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


int Pow(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    return res;
}

int numberOne = ReadData("Введите первое число: ");
int numberTwo = ReadData("Введите второе число: ");

int stepen = Pow(numberOne, numberTwo);

Console.Write(stepen);