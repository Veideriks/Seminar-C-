Console.Clear();

int fun(int [] mas)
{
    int i = 0;
    int n = mas.Length;
    for (i=0; i < n; i++){
        mas[i] = new Random().Next(-10, 11);
        Console.Write($"{mas[i]} ");}
    return i;
}

int [] mas = new int [4];

int kvest (int [] mas)
{
    int i = 0;
    int x = 0;
    int n = mas.Length;
    for (i=0; i < n; i++){
        if (i % 2 == 1)
            x = mas [i] + x;
        }
        Console.Write($"Сумма элементов на нечетных позициях: {x}");
    return i;
}

fun(mas);
Console.WriteLine();
kvest(mas);