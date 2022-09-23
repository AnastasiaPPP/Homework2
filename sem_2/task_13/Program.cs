using static System.Console;
int num = int.Parse(ReadLine()!);
if (num < 99)
{
    WriteLine("Третьего числа нет");
    return;
}
int Find (int a)
{
    a = a / 100 % 10;
    return a;
}
WriteLine(Find(num));


