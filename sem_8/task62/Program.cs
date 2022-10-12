using static System.Console;
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] cube = new int[4, 4];
int count = 1;
for (int i = 0; i < cube.GetLength(0); i++)
{
   for (int j = 0; j < cube.GetLength(1); j++)
   {
    if (j<cube.GetLength(1))
    {
        cube[i , j] = count;
        count ++;
    }
    else 
    {
        i++;
        cube[i, j] = count;
        count++;
    }
     

   }
    
}