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

