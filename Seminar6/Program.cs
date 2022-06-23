// Задача на разворот массива

/*
int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length -1;

    for(int i = 0; i < array.Length / 2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

int[] myArray = {2, 4, 6, 8, 10};

myArray = ReverseArray(myArray);

for(int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
*/


//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/*
bool TrianglePossibility(int numA, int numB, int numC)
{
   if ((numA + numB > numC) && (numB + numC > numA) && (numC + numA > numB)) return true;
   return false; 
}

Console.WriteLine(TrianglePossibility (3, 3, 3));
*/


//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

/*

int ArrayFibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < num; i++)
    {
        array[i] = array[i-2] + array[i-1];
    }
    return array;
}

string ArrayToString(int[] array)
{
    string[] arrayString = new String[array.Length];
    string arrayToString = "";
    for(int i = 0; i < array.Length; i++)
    {
        arrayString[i] = Convert.ToString(array [i]);
    }
    ArrayToString = string.Join(", ", arrayString);
    return ArrayToString;
}

Console.WriteLine(ArrayToString(ArrayFibonacci(4)));

*/


//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string DecimalToDoble(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2; // num = num / 2
    }
    return result;
}

Console.WriteLine(DecimalToDoble(8));