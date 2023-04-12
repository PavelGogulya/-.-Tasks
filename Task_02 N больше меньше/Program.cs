// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
    Console.WriteLine ($" максимальное число {num1}, а минимальное {num2}");
}
if (num2 > num1)
{
    Console.WriteLine ($" максимальное число {num2}, а минимальное {num1} ");
}
