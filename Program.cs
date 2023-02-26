Console.Clear();
int x = int.Parse(Console.ReadLine());
int fun (int x)
{
    int y = 0;
    int z = 0;
    while (x!=0){
    y = x%10;
    x = x/10;
    z = z+y;}
    return z;
}

Console.WriteLine(fun(x));
