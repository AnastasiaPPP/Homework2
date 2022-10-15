using static System.Console;

int m = int.Parse(ReadLine()!);
int n = int.Parse(ReadLine()!);
if(m < 0 || n < 0) return;
WriteLine(AckermannFunc(m, n));

int AckermannFunc (int m, int n)
{
    if(m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermannFunc(m - 1, 1);
    else return AckermannFunc(m - 1, (AckermannFunc(m, n - 1)));
}