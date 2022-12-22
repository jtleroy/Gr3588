int ReadData(string msg)
{
    Console.WriteLine(msg);
     return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

bool TriangleTest(int a, int b, int c)

{
    return((a + b > c) && (a + c > b) && (b + c >a));
}

int a = ReadData("Введите первое число: ");
int b = ReadData("Введите второе число: ");
int c = ReadData("Введите третье число: ");

if(TriangleTest(a, b, c)) PrintData("Может существовать треугольник со сторонами такой длины.");
else PrintData("Треугольгник со стороны такой длины не существует.");