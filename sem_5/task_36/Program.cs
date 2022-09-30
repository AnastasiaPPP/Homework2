using static System.Console;
WriteLine("Задайте длину массива:");
int number = int.Parse(ReadLine()!);
int[] array = MakeArray(number);
String strArr = String.Join(", ", array);
WriteLine(strArr);
FindSum(array);

int[] MakeArray(int num)
{   
    Random rnd = new Random();
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
    return array;
}
  
void FindSum (int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    WriteLine($"Сумма элементов нечетных позиций: {sum}");
  }
