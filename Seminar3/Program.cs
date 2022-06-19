// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int FindQuart (int x, int y)
{
    if (x > 1 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;

    return -1;
}

int num1;
int num2;

Console.WriteLine("Введите координату по оси Х");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Y");
num2 = Convert.ToInt32(Console.ReadLine());


int result = FindQuart(num1, num2);

if(result == -1) Console.WriteLine("Точка расположена на одной из осей");
else Console.WriteLine($"Точка находится в {result} четверти");

*/

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void FindRange(int A)
{
    if (A == 1)
    {
        Console.WriteLine("x > 0, y > 0");
    }  
    else if (A == 2) 
    {
        Console.WriteLine("x < 0, y > 0");
    }
    else if (A == 3) 
    {
        Console.WriteLine("x < 0, y < 0");
    }
    else if (A == 4) 
    {
        Console.WriteLine("x > 0, y < 0");
    }

    else 
    {
        Console.WriteLine("Четвертей всего четыре");
    }
}

Console.WriteLine("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());

FindRange(num);

*/


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*
void Quad(int num)
{
    int current = 1;
    while(current <= num)
    {
        Console.Write((current*current) + " ");
        current++;
    }
}

Console.WriteLine("Введите число");
int azaza = Convert.ToInt32(Console.ReadLine());

Quad(azaza);
*/

// Нахождение расстояния между точками

double FindLenght(double xA, double yA, double xB, double yB)
{
   return Math.Sqrt((xB-xA)*(xB-xA) + Math.Pow((yB - yA),2)); //Math.Pow возводит в степень
}

Console.WriteLine("Введите координату xA");
double xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату yA");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату xB");
double xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату yB");
double yB = Convert.ToDouble(Console.ReadLine());

double result = FindLenght(xA,yA,xB,yB);

Console.WriteLine($"Расстояние между точками A и B {result} единиц");
