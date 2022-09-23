using static System.Console;
int x1 = int.Parse(ReadLine()!);
int y1 = int.Parse(ReadLine()!);
int z1 = int.Parse(ReadLine()!);
int x2 = int.Parse(ReadLine()!);
int y2 = int.Parse(ReadLine()!);
int z2 = int.Parse(ReadLine()!);
double dist = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
WriteLine($"{dist:f2}");
