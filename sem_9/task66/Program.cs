using static System.Console;

int x = int.Parse(ReadLine()!);
int y = int.Parse(ReadLine()!);
int res = GetSum(x, y);
WriteLine(res);
int GetSum(int m, int n)
{
    if(n == m) return m;
    else return GetSum(m, n - 1) + n;
}