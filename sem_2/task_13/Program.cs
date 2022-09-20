using static System.Console;
int num = int.Parse(ReadLine()!);
if (num > 99)
    {
        num = num / 100 % 10;
        WriteLine(num);
    }
    else 
    {
        WriteLine("Третьей цифры нет");
    }