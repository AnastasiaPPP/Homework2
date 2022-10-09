using static System.Console;
Clear();
WriteLine("Задайте размер массива");
WriteLine("Строки: ");
int rows = int.Parse(ReadLine()!);
WriteLine("Столбцы: ");
int col = int.Parse(ReadLine()!);
WriteLine();

WriteLine("Задайте позицию элемента для проверки:");
WriteLine("Строка: ");
int a = int.Parse(ReadLine()!);
WriteLine("Столбец: ");
int b = int.Parse(ReadLine()!);
WriteLine();
if (a > rows || b > col)
{
    WriteLine("Такой позиции нет");
    return;
}
a -= 1;
b -= 1;
int[,] matrix = new int[rows, col];
FillRandomNumbers(matrix);
PrintArray(matrix);
WriteLine();
CheckElement(matrix, a, b);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillRandomNumbers(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}

void CheckElement(int[,] matr, int x, int y)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == x && j == y) WriteLine(matr[i, j]);           
        }
    }
}
