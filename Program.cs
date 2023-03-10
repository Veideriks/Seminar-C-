using System;
using static System.Console;

Clear();

int rows = 5;
int columns = 5;
int[,] array = GetArray(rows, columns);
PrintArray(array);
WriteLine("");
kvest(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0,2);
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

// увы так и не придумал как идею оформить так, чтобы не выходить за пределы матрицы в проверках Index was outside the bounds of the array.
int [,] kvest (int [,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            int verh = array [i,m-1];
            int niz = array [i,0];
            int pravo = array [0,j];
            int levo = array [n-1,j];
            if (i==0 && j==0)
                if (array[i,j] ==0)
                    if (levo + array [i+1,j] + array [i,j+1] + verh ==3)
                        array[i,j] =1;
                if (array[i,j] ==1)
                    if (levo + array [i+1,j] + array [i,j+1] + verh !=3 || levo + array [i+1,j] + array [i,j+1] + verh !=2)
                        array[i,j] =0;
            if (i==0 && j==m-1)
                if (array[i,j] ==0)
                    if (levo + array [i+1,j] + niz + array [i,j-1] ==3)
                        array[i,j] =1;
                if (array[i,j] ==1)
                    if (levo + array [i+1,j] + niz + array [i,j-1] !=3 || levo + array [i+1,j] + niz + array [i,j-1] !=2)
                        array[i,j] =0;
            if (i==n-1 && j==0)
                if (array[i,j] ==0)
                    if (array[i-1,j] + pravo + array [i,j+1] + verh ==3)
                        array[i,j] =1;
                if (array[i,j] ==1)
                    if (array[i-1,j] + pravo + array [i,j+1] + verh !=3 || array[i-1,j] + pravo + array [i,j+1] + verh !=2)
                        array[i,j] =0;
            if (i==n-1 && j==m-1)
                if (array[i,j] ==0)
                    if (array[i-1,j] + pravo + niz + array [i,j-1] ==3)
                        array[i,j] =1;
                if (array[i,j] ==1)
                    if (array[i-1,j] + pravo + niz + array [i,j-1] !=3 || array[i-1,j] + pravo + niz + array [i,j-1] !=2)
                        array[i,j] =0;
            if (i!=0 && j!=0 && i+1!=n && j+1!=m)
                if (array[i,j] ==0)
                    if (array[i-1,j] + array [i+1,j] + array [i,j+1] + array [i,j-1] ==3)
                        array[i,j] =1;
                if (array[i,j] ==1)
                    if (array[i-1,j] + array [i+1,j] + array [i,j+1] + array [i,j-1] !=3 || array[i-1,j] + array [i+1,j] + array [i,j+1] + array [i,j-1] !=2)
                        array[i,j] =0;
        }
    }
    WriteLine("");
    Write(array);
    return array;
}

// изначально идея была такая, потом попробовал прописать просто исключения и либо там запутался, либо что-то не верно
//  if (i==0)
//                 array [i-1,j] = levo;
//             if (i==n-1)
//                 array [i+1,j] = pravo;
//             if (j==m-1)
//                 array [i,j+1] = niz;
//             if  (j==0)
//                 array [i,j-1] = verh;