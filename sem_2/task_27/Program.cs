using static System.Console;
int num = int.Parse(ReadLine()!);
int finalNum = GetSum(num);
Write(finalNum);


int GetSum (int x)
{
    int rem = 0;
    int res = 0;
    while(x > 0)
    {
        rem = x % 10;
        res += rem;
        x /= 10;
    }
    return res;
}