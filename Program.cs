Console.Clear();

double fun(double [] mas)
{
    int i = 0;
    int n = mas.Length;
    for (i=0; i < n; i++){
        mas[i] = new Random().NextDouble();
        mas[i] = Math.Round (mas[i], 3);
        Console.Write($"{mas[i]} ");}
    return i;
}

double [] mas = new double [4];

double kvest (double [] mas)
{
    int i = 0;
    double min = mas [i];
    double max = 0;
    double sum = 0;
    double n = mas.Length;
    for (i=0; i < n; i++){
        if (mas[i] < min)
            min = mas [i];
        if (mas[i] > max)
            max = mas [i];}
        sum = min + max;
        Console.Write($"Сумма min + max: {sum}");
    return i;
}

fun(mas);
Console.WriteLine();
kvest(mas);