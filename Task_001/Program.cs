﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Написать программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго ?
// a = 25, b = 5 ->да,
// a = 2, b = 10 ->нет,
// a = 9, b = -3 ->да,
// a = -3, b = 9 ->нет.

Console.WriteLine("ВВедите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine($ "Ураа число {numberA}  является квадратом числа {numberB}");
}
else
{
    
}