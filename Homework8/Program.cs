// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

int[,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int[m,n];

    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            array[i,j] = new Random() .Next(min, max + 1);
    return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

int[,] ReArrange(int[,] array)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            if(array[i,k] < array[i,j])
            {
                temp = array[i,j];
                array[i,j] = array[i,k];
                array[i,k] = temp;
            }
        }
    }
    return array;
}

int[,] array = CreateTwoDimArray(4, 5, 1, 9);
ShowArray(array);
Console.WriteLine();
array = ReArrange(array);
ShowArray(array);
