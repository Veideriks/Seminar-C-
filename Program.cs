using System;
using static System.Console;

Clear();

int n = 3;
int m = 2;

WriteLine(kvest (n,m));

int kvest (int n, int m)
{
    if (n==0)
        return m+1;
    else if (m==0)
        return kvest (n-1, 1);
    return kvest (n-1, kvest (n,m-1));
}
