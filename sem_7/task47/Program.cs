using static System.Console;
Clear();

WriteLine("Задайте размера массива");
WriteLine("Строки: ");
int m = int.Parse(ReadLine()!);
WriteLine("Столбцы: ");
int n = int.Parse(ReadLine()!);

double[,] matrix = new double[m, n];

WriteLine();
FillRandomNumbers(matrix);
PrintArray(matrix);

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f1}" + "\t");
        }
        Console.WriteLine();
    }
}

double[,] FillRandomNumbers(double[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.NextDouble()+rand.Next(-10,10);
        }
    }
    return matr;
}
