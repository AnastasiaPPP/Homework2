using static System.Console;
int num = int.Parse(ReadLine()!);
int save = num;
int rev = 0;
if (num < 10000 || num > 99999) {
    WriteLine("Это не пятизначное число");
    return;
}
while (num > 0) 
{
int temp = num % 10;
rev = rev * 10 + temp;
num /= 10;
}
WriteLine(save == rev?"Является палиндромом":"Не является палиндромом");
