// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Введите количество чисел для проверки ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] newArray = new int[arraySize];

for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine("Введите число номер " + (i+1));
    newArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();

for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}

Console.WriteLine();

int AmountOfPositive(int[] newArray)
{
  int sum = 0;
  for(int i = 0; i < newArray.Length; i++)
  {
    if(newArray[i] > 0) sum++;
  }
  return sum;
}

Console.WriteLine("Количество чисел больше нуля " + AmountOfPositive(newArray));
*/

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования


int[] NewArray(int size, int min, int max)
{
    int [] myArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(min, max + 1);
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
    return myArray;
}

int[] CopyOfArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
        Console.Write(copy[i] + " ");
    }
    return array;
}

Console.WriteLine("Original array:");
int[] Result = NewArray(10, -10, 10);
Console.WriteLine("Copy of array:");
CopyOfArray(Result);
