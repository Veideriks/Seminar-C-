Console.Clear();

int fun(int [] mas)
{
    int i = 0;
    int n = mas.Length;
    for (i=0; i < n; i++){
        mas[i] = new Random().Next(0, 101);
        Console.Write($"{mas[i]} ");}
    return i;
}

int [] mas = new int [8];
fun(mas);
