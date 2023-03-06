Console.Clear();

int fun(string mes)
{
    Console.Write(mes);
    string value = Console.ReadLine();
    int res = int.Parse(value);
    return res;
}

int[] input (int length)
{
    int [] mas = new int [length];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = fun($"Vvod element({i + 1}) ");
    }
    return mas;
}

void print(int[]mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {mas[i]}");
    }
}

int count(int[]mas)
{
    int count = 0;
    for (int i = 0; i<mas.Length; i++)
    {
        if (mas[i]>0)
        {
            count++;
        }
    }
    return count;
}

int length = fun ("Vvod 4isel ");
int [] mas;
mas = input(length);
print(mas);
Console.WriteLine($"kol-vo 4isel > 0 ---> {count(mas)}");