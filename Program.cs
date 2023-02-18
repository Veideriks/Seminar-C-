Console.Clear();
Console.WriteLine("Введите число-день недели");
int x = int.Parse(Console.ReadLine());

if ((x<6) && (x>0))
    {
        Console.WriteLine ("Будний день");
    }
if ((x<8) && (x>5))
    {
        Console.WriteLine ("Выходной день");
    }
if ((x>=8) || (x<=0))
    {
        Console.WriteLine ("Такого дня не существует");
    }