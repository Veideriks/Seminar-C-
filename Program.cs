Console.Clear();

int fun(int [] mas)
{
    int i = 0;
    int n = mas.Length;
    for (i=0; i < n; i++){
        mas[i] = new Random().Next(100, 1000);
        Console.Write($"{mas[i]} ");}
    return i;
}

int [] mas = new int [5];

int kvest (int [] mas)
{
    int i = 0;
    int x = 0;
    int n = mas.Length;
    for (i=0; i < n; i++){
        if (mas [i] % 2 == 0)
            x++;
        }
        Console.Write($"4etn 4isel {x}");
    return i;
}

fun(mas);
Console.WriteLine();
kvest(mas);