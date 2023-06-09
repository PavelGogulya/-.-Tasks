﻿// Задача 31: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size, int min, int max) // создаем массив со случайными натуральными числами
{
    int[] arr = new int[size]; // новый массив с размером size
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr) //  метод void поскольку массив ниччего не должен возвращать в вконсоль, он пустой
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if (i < arr.Length - 1) Console.Write($"{arr[i] }, ");
       else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int GetSumNegativeElem(int[] arr) // метоод Нахождения суммы отрицательных  элементов массива.
{
    int Sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) Sum +=arr[i];
    }
    return Sum;
}

int GetSumPositiveElem(int[] arr) // метод Находения суммы положительных чисел. (перевод: "Получить сумму положительных чисел")
{
    int Sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) Sum +=arr[i];
    }
    return Sum;
}

int[] array = CreateArrayRndInt(12, -9, 99);
PrintArray(array);
Console.WriteLine();
int sumNegativeElem = GetSumNegativeElem(array);
int sumPositiveElem = GetSumPositiveElem(array);

Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveElem}");



// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]"}, ");
//     }

// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
