/*
int num1, num2;

Console.Write("Input first number ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("max = " + num1);
}
else
{
    Console.WriteLine("max = " + num2);
}
*/

/*
int num1, num2, num3, max;

Console.Write("Input first number ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if (max <= num2)
{
    max = num2;
}
else
{
    max = num1;
}
if (max <=num3)
{
    max = num3;
}
else
{
    max = num1;
}

Console.WriteLine("max = " + max);
*/

/*
int num;

Console.Write("Input number ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}
*/

int num, current;

current = 1;

Console.Write("Input number ");
num = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
        current++;
    }
    else
    current++;
    if (current > num)
    {
        break;
    }
}