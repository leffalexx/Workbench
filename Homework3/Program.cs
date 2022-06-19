//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
bool IfPalindrome (int num)
{
    int first = num / 10000;
    int second = (num / 10000) - (num / 1000);
    int fourth = (num % 100) / 10;
    int fifth = num % 10;
    if ((first ==  fifth) && (second == fourth)) return true;
    else return false;
}
int num;

Console.WriteLine("Input 5 digit number to check if it's a palindrome ");
num = Convert.ToInt32(Console.ReadLine());

bool result = IfPalindrome(num);

Console.WriteLine(result);
*/

void Qube(int num)
{
    int current = 1;
    while(current <= num)
    {
        Console.Write(Math.Pow(current,3) + " ");
        current++;
    }
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Qube(num);