﻿
/*
int MiddleDigit(int num)
{
    int hund = num / 100;
    int dig = num % 10;
    int result = (num - hund*100 - dig)/10;
    return result;
}

int num;

Console.Write("Input 3 digit number ");
num = Convert.ToInt32(Console.ReadLine());

int result = MiddleDigit(num);

Console.WriteLine(result);
*/




int ThirdDigit(int num)
        {
     
            if (num < 100)
            {
                Console.WriteLine("Третьей цифры нет");
                return -1;
            }
            else
                {
                while (num / 1000 > 1)
                {
                    num = num / 10;
                }
            }
            num = num % 10;
            return num;
        }

        int num;

        Console.Write("Input any number ");
        num = Convert.ToInt32(Console.ReadLine());

        int result = ThirdDigit(num);

        Console.WriteLine(result); 





