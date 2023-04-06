﻿// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

int GetSumNegativeElem(int[] arr) // Находим сумму отрицательных  элементов массива.
{
    int Sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) Sum +=arr[i];
    }
    return Sum;
}

void InvertArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

int[] array = CreateArrayRndInt(12, -9, 9);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();
InvertArray(array);
Console.WriteLine("Инвертированный массив:");
PrintArray(array);

