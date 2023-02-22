Console.Clear();

Console.WriteLine("Введите: x");
int x = int.Parse(Console.ReadLine());
int count = 1;
int countminys = -1;
int k = 0;

while (count <= x){
    k = count*count*count;
    Console.Write($"{k} ");
    count = count + 1;}

while (countminys >= x){
    k = x*x*x;
    Console.Write($"{k} ");
    x = x + 1;}