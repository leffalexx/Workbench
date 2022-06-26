
//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size)
{
  int[] newArray = new int[size];

  for (int i = 0; i < size; i++)
  {
    newArray[i] = new Random() .Next(100, 1000);
    Console.Write(newArray[i] + " ");
  }
  Console.WriteLine();

  return newArray;
}

int CountingEven (int[] array)
{
    int even = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        even++;
    }
    return even;
}

int[] myArray = CreateRandomArray(20);

Console.WriteLine("amount of even numbers is " + CountingEven(myArray));
*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size)
{
  int[] newArray = new int[size];

  for (int i = 0; i < size; i++)
  {
    newArray[i] = new Random() .Next(-100, 100);
    Console.Write(newArray[i] + " ");
  }
  Console.WriteLine();

  return newArray;
}

int SumOfOddIndexes (int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
        {
            sum = array[i] + sum;
        }
    return sum;
}

int[] myArray = CreateRandomArray(20);

Console.WriteLine("sum of odd indexes is " + SumOfOddIndexes(myArray));
*/

//Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size)
    {
        double[] newArray = new double[size];
        for (int i = 0; i < size; i++)
        {
        newArray[i] = Math.Round(new Random().NextDouble()*1000, 3);
        Console.Write(newArray[i] + " ");
        }
    Console.WriteLine();
    return newArray; 
    } 

double MaxMinusMin(double[] array) 
    {
        double min = array[0];
        double max = array[0];
                for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
        double diff = Math.Round(max - min, 3);
        return diff;
    }

    double[] newArray = CreateRandomArray(5);
    Console.WriteLine("The difference is " + MaxMinusMin(newArray));