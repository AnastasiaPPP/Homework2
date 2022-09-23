using static System.Console;
int num = int.Parse(ReadLine()!);
int i = 1;
while (i <= num)
{
double cube = Math.Pow(i, 3);
Write($"{cube}, ");
i++;
}