using System;
using static System.Console;

Clear();

int rows = 4;
int columns = 4;
int[,] array = GetArray(rows, columns);
PrintArray(array);
WriteLine("");
kvest(array);
PrintArray(array);

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

int [,] kvest (int [,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    int swap = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for(int k = array.GetLength(1); k > 0 ; k--)
            {
                for(j = 0 ; j < m ; j++)
                {
                    if (j!=m-1 && array[i,j] < array[i,j+1])
                    {
                        swap = array[i,j];
                        array[i,j] = array[i,j+1];
                        array[i,j+1] = swap;
                    }
                }
            }
        }
    }
    WriteLine("");
    return array;
}