using static System.Console;
WriteLine("Задайте длину массива:");
int number = int.Parse(ReadLine()!);
double[] array = MakeArray(number);
String strArr = String.Join("   ", array);
WriteLine(strArr);
double minimum = FindMin(array);
double maximum = FindMax(array);
FindDifference(maximum, minimum);


double[] MakeArray(int num)
{   Random rnd = new Random();
    double[] array = new double[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100, 1);
    }
    return array;
}
 double FindMin (double[] arr)
 {
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
 }
 double FindMax (double[] arr)
 {
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
 }
 
 void FindDifference(double a, double b)
 {
    double result = a - b;
    WriteLine($"Разница между максимальным и минимальным значением: {result:f1}");
 }