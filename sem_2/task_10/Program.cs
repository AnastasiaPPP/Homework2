using static System.Console;
int num = int.Parse(ReadLine()!);
if (num < 100 || num > 999) {
    WriteLine("Число не трехзначное");
    return;
}
int Find (int a) {
    a = a / 10 % 10;
    return a;
}
WriteLine(Find(num));