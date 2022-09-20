using static System.Console;
int day = int.Parse(ReadLine()!);
WriteLine(day == 6 || day == 7?"Это выходной день":"Это рабочий день");