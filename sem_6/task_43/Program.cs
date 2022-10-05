using static System.Console;

WriteLine("Введите через пробел значения b1, k1, b2, k2");
string[] inputs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
GetPoint(double.Parse(inputs[0]), double.Parse(inputs[1]), double.Parse(inputs[2]), double.Parse(inputs[3]));

void GetPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    if(k1 == k2) WriteLine("Линии не пересекаются");
    else WriteLine($"({x:f1}, {y:f1})");
}