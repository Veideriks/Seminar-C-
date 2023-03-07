Console.Clear();

Console.Write("vvod 4isla strok: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("vvod 4isla stolbcov: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns);
PrintArray(array);
sum(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0,11);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int sum(int[,] array)
{
    int result = 0;
    int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(1) : array.GetLength(0); // если условие слева выполняется, то(?), если нет то (:)
    for (int i = 0; i < length; i++)
    {
        result += array[i,i]; 
    }      
    Console.WriteLine(result);
    return result;
}