# Лекция 2
## Знакомство с функциями и массивами

* До 60-х годов код писался "стихийным способом" - если какой-то функционал нужен был, его писали, если нужно было повторить код, его копипастили.
* Для сокращения кода перешли к процедурному подходу.
* Задача с поиском максимального числа адекватно решается только при маленьком количестве чисел. Для больших чисел нужна функция
* Аналогом функций мы пользуемся в жизни постоянно. Мы говорим "свари борщ", а не полный перечень действий - от пукупки продуктов для приготовления. В функции "свари борщ" уже указан набор действий.
* Аналогом аргумента функции является объем необходимого борща
* В программировании функции называются методами
* Мы уже встречались с функциями - например, метод new.Random().Next
* Методы называют также подпрограммами. Они тоже принимают на вход информацию и отдают результат обработки.
* Функция - это часть программного кода, который создает разработчик Она имеет:
1. Идентификатор (имя)
2. Может иметь входные аргументы
3. Может возвращать значение
* Общий вид функции

тип данных наименование(типа аргумента имя аргумента)
{

    Тело метода
}

## Найти максимум из 9 чисел

*Сначала процедурным способом

int a1 = 15;

int b1 = 21;

int c1 = 39;

int a2 = 12;

int b2 = 23;

int c2 = 33;

int a3 = 13;

int b3 = 23;

int c3 = 33;

int max = a1;

if(b1 > max) max = b1;

...... - тут еще 6 строк

if(c3 > max) max = c3;

Console.Write(max);

* Теперь функция

int Max(int arg1, int arg2, int arg3)

{

    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result - arg3;
    return result;
}
* Это функция поиска максимума из трех чисел

* Далее заводим отдельные переменные

int max1 = Max(a1, b1, c1);

int max2 = Max(a2, b2, c2);

int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);

Console.Writeline(max);

* У нас появился кусок кода для поиска максимума из трех. Если появится ошибка, искать ее придется в меньшем количестве кода.
* **Внутри аргумента можно вызвать саму функцию!**

## Массивы

* Массивы используются для отказа от безмерного количества переменных
* Обозначение массива:

тип данных[]имя = {значение 1, значение 2,....}

int[] array = {1, 17...}
* Объявление массива:

int[] array = {0,0,0,0,0} - прямое заполнение

int[] array = new int[5]; - Резервирование массива на 5 элементов

## Вернемся к задаче с обозначением максимума из чисел

int[] array = {11,21,31,41,15,61,17,38,95}; - объявили массив из чисел, среди которых надо найти макcимальное
* индексы в массиве начинаются с 0, т.е. у третьего числа будет индекс 2.

* Опишем метод для поисканужного значения из массива

int [] array = {1, 8, 87, 7, 22, 4};

 int n = array.Length - берет развер массива

 int find = 4;

 int index = 0;

 while(index < n)

{

    if(array[index] == find0
    {
        Console.WriteLine(index);
    }
    index++
}

* Перепишем код с использованием псевдослучайных чисел

void FillArray(int[] collection)

{

    int lenght = collection.Lenght;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)

{

    int count = col.Lenght;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

* Последние 3 строки: объявили массив из 10 чисел, заполнили методом FillArray и вывели методом PrintArray

* void метод - тот, который не возвращает значение. Только принимает.

* Теперь найдем позицию нужного нам элемента

int IndexOf (int[] collection, int find)

{

    int count = collection.Lenght;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++
    }
    return position;
}
* break прерывает цикл при первом совпадении
* -1 принято использовать как аналог фразы "такого элемента здесь нет"
