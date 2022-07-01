// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandomTwoDemArray(int m, int n)
{
    double[,] newMatrix = new double[m, n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newMatrix[i,j] = Math.Round(new Random().NextDouble()*10, 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

double[,] array = CreateRandomTwoDemArray(3, 4);
*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandomTwoDemArray(int heignt, int width, int min, int max)
{
    int[,] newMatrix = new int[heignt, width];
    
    for (int i = 0; i < heignt; i++)
    {
        for (int j = 0; j < width; j++)
        {
            newMatrix[i,j] = new Random() .Next(min, max + 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int[,] array = CreateRandomTwoDemArray(4, 5, 1, 9);

Console.Write("Введите номер строки ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > array.GetLength(0) || y > array.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine(array[x - 1, y - 1]);
}
*/



