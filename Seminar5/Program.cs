//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int[] CreateRandomArray(int size, int min, int max)
{
  int[] newArray = new int[size];

  for (int i = 0; i < size; i++)
  {
    newArray[i] = new Random() .Next(min, max + 1);
    Console.Write(newArray[i] + " ");
  }
  Console.WriteLine();

  return newArray;
}

int FindPositiveSum(int[] array)
{
  int sum = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0) sum += array[i]; // sum = sum + array[i]
  }
  return sum;
}

int FindNagativeSum(int[] array)
{
  int sum = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if(array[i] < 0) sum += array[i];
  }
  return sum;
}

int[] myArray = CreateRandomArray(12,-9,9);

Console.WriteLine("Sum of positive numbers is " + FindPositiveSum(myArray));
Console.WriteLine("Sum of negavie numbers is " + FindNagativeSum(myArray));

