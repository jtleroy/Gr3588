// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

// Метод для создания массива со случайными числами
int[] GetArray(int Length, int minValue, int maxValue)

{
    int[] numbers =  new int[Length];
    Random rnd = new Random();
    for(int i = 0; i < numbers.Length; i ++)
    {
        numbers[i] = rnd.Next(minValue, maxValue);
        //Console.Write(numbers[i] + " ");
    }
    return numbers;
}

// Метод для вывода ответа на задачу в консоль
void PrintData(string text, int value)
{
    Console.WriteLine(text + value);
}

// Метод для вывода массива в консоль
void Print1DAr(int[] array)
{
    for(int i = 0; i< array.Length -1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

// Метод, который выводит сумму чисел в нечетных позициях
int SumOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
        //Console.Write(sum + " ");
    }
    return sum;
}

int[] numbers = GetArray(20, -99, 100);
Print1DAr(numbers);
PrintData("Сумма элементов, стоящих в нечетных позициях: ", SumOddNumbers(numbers));


