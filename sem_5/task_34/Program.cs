using static System.Console;
WriteLine("Задайте длину массива:");
int number = int.Parse(ReadLine()!);
int[] array = MakeArray(number);
String strArr = String.Join(", ", array);
WriteLine(strArr);
CountUp(array);



int[] MakeArray(int num)
{   Random rnd = new Random();
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}
void CountUp(int[] arr)
{
    int result = 0;
    foreach (int item in arr)
    {
        if(item % 2 == 0) result += item;
    }
    WriteLine($"Сумма положительных чисел в массиве - {result}");
}