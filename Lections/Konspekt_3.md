# Лекция 3. Функции: продолжение

## Основные иды методов:
1. Ничего не принимают и не возвращают
2. Принимают, но не возвращают (void)
3. Не принимают, но что-то возвращают (например, генератор случайных чисел)
4. Принимают и влозвращают результат.

Пример первого варианта:

void Method1()

{

    Consile.WriteLine("подпись автора на каждой странице")
}

Этот метод ничего не обрабатывает, просто печатает.

* Вызывается командой Method1(); - со скобками

Пример второго варианта:

void Method2(string msg)

{

    Console.WriteLine(msg);
}

* Вызывается с аргументом: Method2("Текст сообщения");

* Аргументов может быть несколько
* Если цикл случился бесконечным, прерывается через Ctrl + C

Пример третьей группы методов:

int Method3()

{

    return DateTime.Now.Year;
}

int year = Method3();

Console.WriteLine(year);

Четвертый вид методов:

string Method4 (int count, string text)

{

    int i = 0;
    string.result = String.Emplty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "текст")

Console.WriteLine(res);

* Эта градация методов - условная.

## Циклы
* Циклы - не только while. Пример цикла for:

string Method4 (int count, string text)

{

    string.result = String.Emplty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }

    return result;
}
* Метод с циклом for выглядит компактнее
* циклы можно использовать внутри цикла. Вывод таблицы умножения:

for(int i = 2; i <= 10; i++)

{

    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}")
    }
    Console.WriteLine();
}
* Console.WriteLine(); используется для разрыва текста пустой строкой.

## Задача по замене символов в тексте

string text = "Какой-то текст"

string ReplsceChar(string text, char oldValue, char newValue)

{

    string result = String.Empty;
    int Lenght = text.Lenght;
    for(int i = 0; i < lenght; i++)
    {
        if text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, "", "-");
Console.WriteLine(newText);

* "Какой-то-текст" будет результатом работы этого метода (заменили пробел на дефис)

## Задача сортировки массива

* 6 8 3 2 1 4 5 7 7 упорядочить по возрастанию
* Описание метода:
1. Найти позицию минимального элемента в неотсортированной части массива
2. Поменять местами с текцщим элементом
3. Повторять пока есть неотсортированные элементы

int[] arr = {6, 8, 3, 2, 1, 4, 5, 7, 7};
* Сначала напишем метод для вывода массива в консоль

void PrintArray(int[] array)

{

    int count = array.Lenght;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
* Следующий метод - упорядочивание массива

void SelectionSort(int[] array)

{

    for(int i = 0; i < array.Lenght - 1; i++)
    {
        int minPosition = i;
        {
            for(int j = i + 1; j < array.Lenght; j++)
            {
                if(array[j] < array[minPosition])
            } 
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
## Итоги
* Циклов много не бывает
* Бывают циклы в циклах
* Есть 4 основных вида методов
* Признак хорошего тона - описание метода, в котором не более 5 аргументов. Бывают исключения, но редкие.
