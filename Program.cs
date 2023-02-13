Console.WriteLine ("Введите число: ");
int num1 = int.Parse (Console.ReadLine ())!;
Console.WriteLine ("Введите число: ");
int num2 = int.Parse (Console.ReadLine ())!;
Console.WriteLine ("Введите число: ");
int num3 = int.Parse (Console.ReadLine ())!;
int max = num1;
if (num2>max)
    max = num2;
    if (num3>max)
        max = num3;
if (num3>max)
    max = num3;

Console.WriteLine ("Max: " + max);