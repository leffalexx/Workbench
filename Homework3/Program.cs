//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
bool IfPalindrome (int num)
{
    int first = num / 10000;
    int second =  num / 1000 - (num / 10000) * 10;
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


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Qube(int num)
{
       // while (current <= num)
   for (int x = 1; x <= num; x++)
    {
        Console.Write(Math.Pow(x,3) + " ");
        //current++;
    }
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Qube(num);
*/



//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве


double ThreeDLength (double xA, double yA, double zA, double xB, double yB, double zB)
{
   return Math.Sqrt(Math.Pow((xB-xA),2) + Math.Pow((yB - yA),2) + (Math.Pow((zB-zA),2))); 
}

Console.WriteLine("Введите координату xA");
double xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату yA");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату zA");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату xB");
double xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату yB");
double yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату zB");
double zB = Convert.ToDouble(Console.ReadLine());

double result;
result = ThreeDLength(xA, yA, zA, xB, yB, zB);

Console.WriteLine(result);