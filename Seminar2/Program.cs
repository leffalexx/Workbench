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





// c = a % b - знак % оставляет остаток от деления
// 5 % 2 -> 1
// 5 / 2 -> 2 (в случае если тип - Int, "целые числа")

// 1234 - найти тройку

// 1234 / 10 -> 123
// 1234 % 10 -> 4
// 1234 / 10 -> 123 % 10 -> 3
*/

/*Random rnd = new Random();
int number = rnd.Next(100, 999);
Console.WriteLine(number);

int num1, num2;

Console.WriteLine(num1 = number / 100);
Console.WriteLine(num2 = number % 10);
Console.WriteLine($"{num1}{num2}");*/

