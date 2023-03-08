using System;
using static System.Console;

Clear();

int rows = 3;
int columns = 4;
WriteLine("Введите число для поиска: ");
int x = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns);
PrintArray(array);
WriteLine("");
poisk(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1,100);
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

int [,] poisk (int [,] array)
{
    bool result = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [i, j] == x){
                WriteLine($"Число {x} - есть");
                result = true;
            break;}
        }
        if (result == true)
            break;
    }
    if (result == false)
        WriteLine($"Число {x} - отсутствует");
    return array;
}