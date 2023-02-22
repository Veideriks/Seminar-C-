Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int x = int.Parse(Console.ReadLine());

int a = x/10000;
int b = x/1000%10;
int d = x/10%10;
int f = x%10;

if (a==f && b==d){
    Console.WriteLine($"{x} палиндром");}
else
    Console.WriteLine($"{x} не палиндром");
