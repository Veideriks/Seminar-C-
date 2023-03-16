using System;
using static System.Console;

Clear();

int m = int.Parse(ReadLine());
int n = int.Parse(ReadLine());

WriteLine(kvest (m,n));

int kvest (int m, int n)
{
    if (m==n)
        return m;
    return m + kvest(m+1, n);
}
