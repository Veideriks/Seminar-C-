Console.Clear();
int a = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int y=a;
int fun (int a)
{
    int i = 1;
    for (i=1; i < n; i++){
        a=a*y;
        Console.WriteLine(a);}
    return i;
}

fun(a);
