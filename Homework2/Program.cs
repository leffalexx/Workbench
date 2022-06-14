

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

