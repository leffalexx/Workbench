
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