Console.Clear();
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());

while (x > 100000)
    {
    x = x/10;
    }
if (x<100)
    {
        Console.WriteLine ("Третьей цифры нет");
    }
if ((x<1000) && (x>100))
    {
        x = x%10;
        Console.WriteLine (x);
    }
if ((x<10000) && (x>1000))
    {
        x = x%100/10;
        Console.WriteLine (x);
    }
if ((x<100000) && (x>10000))
    {
        x = x%1000/100;
        Console.WriteLine (x);
    }