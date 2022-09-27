using static System.Console;
CreateArray();



int[] CreateArray()
{
    int[] newArr = new int[8];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = new Random().Next(1, 100);
    }
    for (int i = 0; i < newArr.Length; i++)
    {
        if (i == 0)
        {
            Write($"[{newArr[i]}, ");
        }
        else if (i == newArr.Length - 1)
        {
            Write($"{newArr[i]}]");
        }
        else 
        {
            Write($"{newArr[i]}, ");
        }
    }
    return newArr;
    
}