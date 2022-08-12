﻿// Нахождение индекса числа в массиве (случайный порядок чисел)

void FillArray(int[] collection)
{
    int length = collection.Length; // Определение длинны массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //Создание случайного числа в диапозоне 1-10
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10]; //Создание массива в котором будет 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 5);
Console.WriteLine(pos);