using System;
using static System.Console;

Clear();

int rows = 3;
int columns = 4;
int[,] array = GetArray(rows, columns);
PrintArray(array);
WriteLine("");
sum(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1,10);
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

int [,] sum (int [,] array)
{
    int result = 0;
    double srednee = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result = result + array [j,i];
        }
        srednee = Convert.ToDouble(result)/Convert.ToDouble(array.GetLength(0));
        Write($"{srednee} ");
        result = 0;
        WriteLine();
    }
    return array;
}