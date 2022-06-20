//Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Exponent(int a, int b)
{
   // int power = (int)Math.Pow(a,b);
   int power = a;
   for (int count = 1; count < b; count++)
   {
           power = power * a;
   }
    return power;
}

Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число");
int b = Convert.ToInt32(Console.ReadLine());

if(b > 0)
{
  Console.WriteLine("Результат равен " + Exponent(a,b));
}
else
{
Console.WriteLine("Попробуйте еще раз");
}
*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int size = 8;
int[] array = new int[size];

for(int i = 0; i < size; i++)
{
    Console.Write("Введите целое число ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}