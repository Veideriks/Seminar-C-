using System;
using static System.Console;

Clear();

int rows = 2;
int columns = 2;
int[,] array = GetArray(rows, columns);
int[,] array2 = GetArray(rows, columns);
int[,] array3 = kvest(rows, columns);

PrintArray(array);
WriteLine("");
PrintArray(array2);
WriteLine("");
PrintArray(array3);
WriteLine("");

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0,5);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int[,] kvest(int m, int n)
{
    int[,] result = new int[m, n];
    result[0, 0] = array[0,0]*array2[0,0]+array[0,1]*array2[1,0];
    result[0, 1] = array[0,0]*array2[0,1]+array[0,1]*array2[1,1];
    result[1, 0] = array[1,0]*array2[0,0]+array[1,1]*array2[1,0];
    result[1, 1] = array[1,0]*array2[0,1]+array[1,1]*array2[1,1];
    return result;
}