// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

/*

string[] carManufacturers = {"Hispano-Suiza", "Alfa Romeo", "Isotta Fraschini", "Maserati", "Duesenberg", "Cord"};

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);

    Console.WriteLine();
}

int StartWithVowel(string[] array)
{
    int count = 0;
    string vowels = "EeYyUuIiOoAa";
    for(int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (array[i][0] == vowels[j])
            count++;
        }
    }
        
    return count;
}

ShowArray(carManufacturers);
Console.WriteLine("Названий, начинающихся на гласную букву " + StartWithVowel(carManufacturers));

*/
//  Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.


string[] randomWords = {"First", "Watermelon", "Fish", "Coal", "Streetart", "Gym", "Sea"};

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] CombiningPairs(string[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1)
    {
        size++;
    }
    string[] pairs = new string[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        int j = i * 2;
        pairs[i] = array[j] + array[j+1];
    }
    if (array.Length % 2 == 1)
    {
        pairs[size - 1] = array[array.Length - 1];
    }
    return pairs;
}

ShowArray(randomWords);
Console.WriteLine();
ShowArray(CombiningPairs(randomWords));