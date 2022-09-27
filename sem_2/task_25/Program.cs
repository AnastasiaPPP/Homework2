using static System.Console;
int num1 = int.Parse(ReadLine()!);
int num2 = int.Parse(ReadLine()!);
int res = GetDegree(num1, num2);
Write(res);

int GetDegree(int x, int y)
{
    int count = 1;
    int result = 1;
    while (count <= y)
    {
        result *= x;
        count++;
    }
    return result;
}