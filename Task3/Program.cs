﻿//Задача 3: Задайте произвольный массив. Выведете его элементы, 
//начиная с конца. Использовать рекурсию, не использовать циклы.


int[] CreateRandomArray(int min, int max, int size) //Рандомный массив с пользовательским вводом, потому что так сошлись звезды ¯\_(ツ)_/¯
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
}

void ArrayReverse(int[] array, int size)
{
    if (size == 0)
    {
        return;
    }
    Console.Write($"{array[size - 1]} ");
    ArrayReverse(array, size - 1);
}

Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter size value: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(min, max, size);
ShowArray(array);
Console.WriteLine();
ArrayReverse(array, size);