// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.


string[] carManufacturers = {"Hispano-Suiza", "Alfa Romeo", "Isotta Fraschini", "Maserati", "Duesenberg", "Cord"};

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);

    Console.WriteLine();
}

int StartWithWowel(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        {
            if (array[i][0] == 'A' || array[i][0] == 'a' 
             || array[i][0] == 'E' || array[i][0] == 'e'
             || array[i][0] == 'O' || array[i][0] == 'o'
             || array[i][0] == 'Y' || array[i][0] == 'y'
             || array[i][0] == 'U' || array[i][0] == 'u'
             || array[i][0] == 'I' || array[i][0] == 'i')
            count++;
        }
    return count;
}

ShowArray(carManufacturers);
Console.WriteLine("Названий, начинающихся на гласную букву " + StartWithWowel(carManufacturers));
