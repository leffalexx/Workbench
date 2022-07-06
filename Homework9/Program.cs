// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumNumbers (int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return n + SumNumbers(m, n - 1);
    }
}

Console.Write("input lesser number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input bigger number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbers(num1, num2));
*/

// Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.

int QuantityOfDigits(int num)
{
    if (num < 10)
    {
        return 1;
    }    
    else
    {
        return 1 + QuantityOfDigits(num/10);
    }   
}

Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("There are " + QuantityOfDigits(number) + " digits in given number");