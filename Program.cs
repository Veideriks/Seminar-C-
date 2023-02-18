Console.Clear();
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());

int res1 = a%100;
int res2 = res1/10;

Console.WriteLine (res2);