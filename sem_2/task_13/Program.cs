using static System.Console;
int num = int.Parse(ReadLine()!);
while (num > 10) 
{
    if (num < 1000 && num > 99) 
    {
    num = num % 10;
    WriteLine($"Третье число - {num}");
    }
    else if (num > 999) 
    {
   num = num / 10;
    }
    else 
    {
        WriteLine("Третьей цифры нет");
        break;
    }
}