// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
/*
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
*/

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
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

void  MinSumLine(int[,] array)
{
    int sumLine = 0;
    int min = 0;
    int minLine = 0;    
    for(int j = 0; j < array.GetLength(1); j++)
    min += array[0,j];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        sumLine += array[i,j];
        if(sumLine < min)
        {
            min = sumLine;
            minLine = i + 1;
        }
        sumLine = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой {minLine}, ее сумма равна {min}");
}
int[,] array = CreateTwoDimArray(4, 5, 1, 9);
ShowArray(array);
Console.WriteLine();
MinSumLine(array);
*/

//Заполните спирально массив 4 на 4.

int[,] SpiralArray(int m)
{
   int[,] array = new int[m,m];
   int start = 1, rows = m, columns = m, x = 0, y = 0;
   while(x < rows)
   {
       for(int j = x; j < rows; j++)
       {
           array[y, j] = start;
           start++;
       }
       rows = rows - 1;
       for( int i = (y + 1); i < columns; i++)
       {
           array[i, columns-1] = start;
           start++;
       }
       columns = columns - 1;
       for(int j = (rows-1); j >= x; j=j-1)
       {
           array[rows, j] = start;
           start++;
       }
       for(int i = (columns-1); i > y; i = i-1)
       {
           array[i, x] = start;
           start++;
       }
       x++; y++;
   }
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

int[,] array = SpiralArray(4);
ShowArray(array);