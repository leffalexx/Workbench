// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

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
