// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


// Метод, который принимает строку, преобразует его в массив чисел
int[] StringToNumbers(string text)
{
    string[] subs = text.Split(", ");
    int[] newNumbers = new int[subs.Length];
    for (int i = 0; i < subs.Length; i++)
    {
        if (!string.IsNullOrEmpty(subs[i]))
        {
            int number = int.Parse(subs[i]);
            newNumbers[i] = number;
        }
    }
    return newNumbers;
}

// Метод для вывода массива в консоль
void Print1DAr(int[] array)
{
    for(int i = 0; i< array.Length -1; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

// Метод, который находит, сколько чисел больше 0
int CheckNumbers(int[] array)
{
    int count = 0;
    for(int i=0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count = count + 1;
            //Console.Write(array[i] + " ");
        }
    }
    return count;
}


Console.WriteLine("Введите числа через запятую: ");
int[] Numbers = StringToNumbers(Console.ReadLine());
Print1DAr(Numbers);
int res = CheckNumbers(Numbers);
Console.Write("Количество чисел больше 0: " + res);