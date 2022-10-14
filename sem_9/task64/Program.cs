using static System.Console;

WriteLine("Задайте число");
int n = int.Parse(ReadLine()!);
WriteLine(NumbersFromN(n));
string NumbersFromN (int x)
{
    if(x == 1) return "1";
    else return x + " " + NumbersFromN(x - 1);
}