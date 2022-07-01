//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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

