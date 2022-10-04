using static System.Console;
WriteLine("Введите числа через пробел");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] nums2 = Array.ConvertAll(nums, int.Parse);
int res = CountNums(nums2);
Write($"Количество чисел больше ноля: {res}");

int CountNums (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count +=1;
    }
    return count;
}


