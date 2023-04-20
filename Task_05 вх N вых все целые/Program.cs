// Задача 5
// Написать программу, которая на вход принимает число (N), а на выходе показывает все целые числа -N до N.
// 4 -> -4, -3, -2, -1, 1, 2 ,3, 4

Console.WriteLine("введите положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
int count =-number;
while (count <= number)
{
    Console.Write($"{count} ");
    count++;
}
