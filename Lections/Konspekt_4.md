# Рекурсия и двумерные массивы

## Двумерные массивы
* Объявление массива:

{
    
    string[,]table = new int [5,8];
}




* Запятая внутри квадратных скобок говорит, что массив двумерный
* При объявлении размера массива сначала объявляется количество строк (5), потом столбцов (8)


string[,] table = new string [2,5];

table[1, 2] = "слово";

for(int rows = 0; rows < 2; rows++)

{

    for(int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-")
    }
}

}

* Пример с числами (матрица)

int[,] matrix = new int[3,4];

for(int i = 0; i < matrix.GetLenght(0); i++)

{

    for(int j = 0; j < matrix.GetLenght(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}

* matrix.Getlenght(0) берет число строк, matrix.HetLenght(1) берет число столбцов объявленного массива

* Опишем отдельно печатающий матрицу и заполняющий ее случайными числами методы

void PrintArray(int[,] matr)

for(int i = 0; i < matrix.GetLenght(0); i++)

{

    for(int j = 0; j < matrix.GetLenght(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}


void FillArray(int[,] matr)

{

    for(int i = 0; i < matr.GetLenght(0); i++)
    {
        for(int j = 0; j < matr.GetLenght(1); j++)
        {
            matr[i,j] = new Random(). Next(1,10);
        }
    }
}

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

* Здесь мы сначала создали пустой массив, вывели его на экран, после чего заполнили случайными числами и сновы вывели на экран.

## Задача по закраске пикселя

* **Смотрим видео**
* Алгоритм закрашивания замкнутой области:

void FillImage (int row, int col)
{

    if (pic[row, col == 0])
    {
        pic[row,col] = 1;
        FillImage(row - 1; col);
        FillImage(row; col - 1);
        FillImage(row + 1; col);
        FillImage(row; col + 1);
    }
}
* Этот алгоритм ест много ресурсов
* А использвали мы **рекурсию**

# Рекурсия

* Рекурсия - вызов методом самого себя

## Пример: поиск факториала числа методом рекурсиии

5! = 5*4*3*2*1

Значит 5! == 5*4!

* Пишем метод:

int Factorial (int n)

{

    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
* Код очень компактный
* Нужно помнить лимиты типов данных, тип int легко переполнить быстрорастущей функцией

## Пример: ряд Фибоначчи методом рекурсии


double Fibonacci(int n)

{

    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
* Вывод чисел Фибоначчи в консоль:


for int(i = 1; i < 50; i++)

{

    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

* используем тип double для вывода большого значения
* с 40+ значения подсчеит очень медленный

## Еще пример использования рекурсии:

* Обход всех папок в директории





