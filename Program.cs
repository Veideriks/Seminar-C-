using System;
using static System.Console;

Clear();

int rows = 2;
int columns = 2;
int tretie = 2;
int[,,] array = GetArray(rows, columns, tretie);

PrintArray(array);
WriteLine("");
proverka(array);
PrintArray(array);

int[,,] GetArray(int m, int n, int k)
{
    int[,,] result = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                result[i, j, l] = new Random().Next(10, 100);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int l = 0; l < inArray.GetLength(2); l++)
            {
                WriteLine($"{inArray[i, j, l]} {(i, j, l)} ");
            }
        }
    }
}
int[,,] proverka(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                if ((i != 0 && j != 0 && l != 0) && (array[i, j, l] == array[0, 0, 0] || array[i, j, l] == array[0, 0, 1] ||
                    array[i, j, l] == array[0, 1, 1] || array[i, j, l] == array[1, 1, 1] ||
                    array[i, j, l] == array[1, 1, 0] || array[i, j, l] == array[1, 0, 0]))
                {
                    array[i, j, l] = new Random().Next(10, 100);
                    proverka(array);
                }
            else
                break;
            }
        }
    }
    return array;
}