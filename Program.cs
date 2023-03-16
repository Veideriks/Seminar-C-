using System;
using static System.Console;

Clear();

int n = int.Parse(ReadLine());

WriteLine(kvest (n));

string kvest (int n)
{
    if (n==1)
        return "1";
    string s = n.ToString() + " " + kvest(n-1);
    WriteLine (s);
    return s;
}
