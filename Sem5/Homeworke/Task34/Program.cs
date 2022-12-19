// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1


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

// Метод для вывода массива в консоль, если нужно
void Print1DAr(int[] array)
{
    for(int i = 0; i< array.Length -1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

// Метод для вывода данных в консоль
void PrintData(string text, int value)
{
    Console.WriteLine(text + value);
}


int[] CrateArray = GetArray(15, 99, 1000); // Создаю массив, согласно условиям задачи
Print1DAr(CrateArray); // вывожу массив в консоль
int count = 0; // В эту переменную будут попадать четные числа из массива

for(int i = 0; i < CrateArray.Length; i ++) // Этим циклом пробегаюсь по каждому элементу массива
{
    if(CrateArray[i] % 2 == 0) // проверка на четность
    {
        count = count + 1;
    }
}

PrintData("Количество четных чисел в массиве: ", count);
