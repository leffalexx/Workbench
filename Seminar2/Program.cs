/*
int FindMaxPart(int num)
{
int dec, ed;

if (num >= 10 && num <= 99)
    {
        dec = num / 10;
        ed = num % 10;
           if (dec > ed)
           {
              return dec;
           }
              else
                {
                   return ed;
                }
            }
            else
            {
                return -1;
            }
        }

        Console.Write("input 2 digit number");
        int a = Convert.Toint32(Console.Readline());
        
        int result = FindMaxPart(a);
        
        if (result == -1)
        {
            Console.Writeline("your number is not 2-digit!!1");
        }
Console.Writeline(result + "is bigger");
*/


// c = a % b - знак % оставляет остаток от деления
// 5 % 2 -> 1
// 5 / 2 -> 2 (в случае если тип - Int, "целые числа")

// 1234 - найти тройку

// 1234 / 10 -> 123
// 1234 % 10 -> 4
// 1234 / 10 -> 123 % 10 -> 3


/*Random rnd = new Random();
int number = rnd.Next(100, 999);
Console.WriteLine(number);

int num1, num2;

Console.WriteLine(num1 = number / 100);
Console.WriteLine(num2 = number % 10);
Console.WriteLine($"{num1}{num2}");*/


/*int num1, num2;

Console.Write("Input integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

int result;

if (num1 % num2 == 0)
{
    Console.Write("Yes");
}
else
{
    result = num1 % num2;
    Console.Write(result);
}*/


/*int num;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write("Yes");
}
else
{
    Console.Write ("No");
}*/


/*
int FunctionDiv(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        return 1;
    }
    else
    {
        return -1;
    }
}

Console.Write("Input integer number: ");

int num = Convert.ToInt32(Console.ReadLine());

int result  = FunctionDiv(num);

if(result == 1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}*/

/*
int CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine($"Current number is {num}"); // ("Current number is " + num)

    int hund = num / 100;
    int dig = num % 10;

    int result = hund * 10 + dig;
    return result;
}
int b = CutNumber();
Console.WriteLine(b);
*/

/*
string IsAliquot(int num1, int num2)
{
    if(num2 % num1 == 0)
    {
        return "True";
    }
    else
    {
        return "False, rest num is " + (num2 % num1);
    }
} */


