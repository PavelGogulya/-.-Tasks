﻿
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
       else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

bool FindElemInArray (int[] arr, int findNum)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]==findNum) return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(12, -9, 9);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Введите число, которое будем искать в массиве:");
int searchNum = Convert.ToInt32(Console.ReadLine());

bool result = FindElemInArray(array, searchNum);
// if (result) Console.WriteLine("да");
// else Console.WriteLine("нет");

Console.WriteLine(result? "да": "Нет");
