Console.Clear();

const int coef = 0;
const int cons = 1;
const int x = 0;
const int y = 1;
const int line1 = 1;
const int line2 = 2;

double [] linedata1 = input(line1);
double [] linedata2 = input(line2);

double zapros (string mes) // запрос значений с преобразоанием из строки.
{
    Console.Write(mes);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double [] input (double number) // вводятся данные по прямой
{
    double [] linedata = new double [2];
    linedata [coef] = zapros($"ввод коэфа: {number}");
    linedata [cons] = zapros($"ввод конса: {number}");
    return linedata;
}

double [] poisk (double[] linedata1, double[] linedata2)
{
    double [] coord = new double [2];
    coord [x] = (linedata1[cons] - linedata2[cons])/(linedata2[coef] - linedata1[coef]);
    coord [y] = linedata1[cons]* coord[x] + linedata1[cons];
    return coord;
}

bool proverka (double [] linedata1, double [] linedata2)
{
    if (linedata1[coef] == linedata2[coef])
    {
        if (linedata1[cons]==linedata2[cons])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
    else
        {
            Console.WriteLine("Прямые паралельны");
            return false;
        }
    }
    return true;
}

if (proverka(linedata1,linedata2))
{
    double [] coord = poisk (linedata1,linedata2);
    Console.WriteLine($"Точка пересечения имеет координаты: ({coord[x]};{coord[y]})");
}