Console.WriteLine ("Введите число: ");
int num = int.Parse (Console.ReadLine ())!;

if (num < 0)
    num = num*(-1);

int numx = num%2;
if (numx == 0)
    Console.WriteLine (num + " Четное число");
if (numx == 1)
    Console.WriteLine (num + " Нечетное число");


// почему то вариант ниже не сработал, выводилось и что четное и что не четное одновременно
//if ((num%2)==1);
   // Console.WriteLine (num + " Нечетное число");
//if ((num%2)==0);
    //Console.WriteLine (num + " Четное число");