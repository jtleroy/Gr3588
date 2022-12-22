// // Метод, считывающий данные, введенные пользователем
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Метод, выводящий данные пользоателю
// void PrintData(string res)
// {
//     Console.WriteLine(res);
// }

// Метод, генерирующий массив
int[] GetArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for( int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

// Метод, выводящий на печать массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] SwapArray(int[] arr)
{
    int bufElement = 0;
    for( int i = 0; i < arr.Length/2; i++)
    {
        bufElement = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = arr[i];
        arr[i] = bufElement;
    }
    return arr;
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for( int i = 0; i < arr.Length; i++)
    {
      outArr[i] = arr[arr.Length-1-i];
    }
    return outArr;
}


int[] arr = GetArray(20, 1, 100);
Console.WriteLine("Исходный массив: ");
Print1DArr(arr);

int[] copyArr = SwapNewArray(arr);
Console.WriteLine("Новый массив перевернутый: ");
Print1DArr(copyArr);
Print1DArr(arr);

int[] copyArrTwo = SwapArray(arr);
Console.WriteLine("Исходный массив: ");
Print1DArr(arr);
Console.WriteLine("Новый массив перевернутый вторым методом: ");
Print1DArr(copyArrTwo);