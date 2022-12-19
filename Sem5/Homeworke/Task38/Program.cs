// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6


// Метод для создания массива со случайными вещественными числами
double[] GetArray(int Length, double maxValue)

{
    double[] numbers =  new double[Length];
    Random rnd = new Random();
    for(int i = 0; i < numbers.Length; i ++)
    {
        numbers[i] = rnd.NextDouble()*maxValue;
        Console.Write(String.Format("{0:0.00}", numbers[i]) + "  ");
    }
     Console.WriteLine();
    return numbers;
}

// Метод для нахождения максимального числа в массиве
double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

// Метод для нахождения минимального числа в массиве
double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

// Метод для выведения в коноль, найденных значений
void PrintData(string text, double value)
{
    Console.WriteLine(text + String.Format("{0:0.00}", value));
}


double[] numbers = GetArray(10, 2);
double max = MaxNumber(numbers);
PrintData("Максимальное число в массиве: ", max);
double min = MinNumber(numbers);
PrintData("Минимальное число в массиве: ", min);
double difference = max - min;
PrintData("Разница между максимальным и минимальным элементов массива: ", difference);