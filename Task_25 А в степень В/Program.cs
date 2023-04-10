// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень в которую нужно возвести число");
int exponent = Convert.ToInt32(Console.ReadLine());

// while (true)
// if (int.TryParse(Console.ReadLine(), out number))

// {
//     Console.WriteLine("Введите степень в которую нужно возвести число");
    
// }
//     else Console.WriteLine("Число не соответсвует запросу, введите НАТУРАЛЬНОЕ число ");

double result = Math.Pow(number, exponent);
Console.WriteLine(result);


