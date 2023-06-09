﻿// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.

//Булгаков Андрей

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");

int SumNumbers(int num) // int num = number
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum = sum + i; // sum += i/ Хотя фигурные скобки '{}' можем опустить, поскольку одно действие
    }
    return sum;
}


//                  Игорь. Поиск Факториала

// Console.WriteLine($"Введите целое положительное число A:");

// int numberA = Convert.ToInt32(Console.ReadLine());

// int result = Factorial(numberA);
// Console.WriteLine($"Результат вычисления факториала: {result}");

// int Factorial(int num) // int num = number
// {
//     int resultFactorial = 1;
//     for(int i = 1; i <= num; i++)
//     {
//         resultFactorial *= i; // sum += i/ Хотя фигурные скобки '{}' можем опустить, поскольку одно действие
//     }
//     return resultFactorial;
// }
