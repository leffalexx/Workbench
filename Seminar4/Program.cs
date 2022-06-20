
// Найти сумму цифр в числе
/*
int FindSumOfDigits(int num)
{
    int sum = 0;

    while(num > 0)
    {
        sum = sum + num % 10; //sum += num % 10;
        num = num / 10;       // num /= 10;
    }
    return sum;
}

int n = 234;
int result = FindSumOfDigits(n);

Console.WriteLine($"Сумма цифр в числе {n} равна {result}");
*/

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int SumTillA(int A)
{
    int current = 1;
    int result = 0;

    while (current <= A)
    {
        result = result + current;
        current++;
    }
        return result;
}

Console.WriteLine ("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int result = SumTillA(A);

Console.WriteLine ($"Сумма чисел равна {result}");
*/


// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

/*
int MultiN (int N)
{
    int current = 1;
    int sum = 1;
    while (current <= N)
    {
        sum = sum * current;
        current++;
    }
    return sum;
}

Console.WriteLine ("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int result = MultiN(N);

Console.WriteLine ($"Факториал введенного числа равен {result}");
*/


// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

/*
int Quant(int num)
{
    int current = 1;
    while (num > 9)
    {
        num = num / 10;
        current++;
    }
    return current;
}

Console.WriteLine ("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int result = Quant(N);

Console.WriteLine ($"Количество цифр в числе {N} равно {result}");
*/



//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

/*
int size = 8;
int[] array = new int[size];

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0,2);
}

for (int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}
*/
