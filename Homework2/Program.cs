
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


/*
int ThirdDigit(int num)
    {
        string numStr = "" + num;
        if(numStr.Length < 3)
        {
            Console.WriteLine("Третьей цифры нет");
            return -1;
        }

        char thirdNum = numStr[2]; 
        return Int32.Parse("" + thirdNum);
    }

        int num;

        Console.Write("Input any number ");
        num = Convert.ToInt32(Console.ReadLine());

        int result = ThirdDigit(num);

 if(result >= 0)
    {
   Console.WriteLine(result);
    } 
*/


/*
bool WeekEnd(int num)
{
    if(num > 5) return true;
    else return false;
}

int num;

Console.Write("Input number of day to see if it's a weekend ");
num = Convert.ToInt32(Console.ReadLine());

bool result = WeekEnd(num);

Console.WriteLine(result);
*/



