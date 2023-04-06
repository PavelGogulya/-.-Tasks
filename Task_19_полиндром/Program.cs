
// Задача 19. Написать программу, которая на вход  принимает пятизначное число и проверяет является ли оно полиндромом 

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int a1 = number % 10;
int a2 = number / 10 % 10;
int a3 = number / 100 % 10;
int a4 = number / 1000 % 10;
int a5 = number / 10000;
int pSum = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;

if( number == pSum)

{
Console.Write($"{number} есть полиндром");
}
else
Console.WriteLine($"Число {number} НЕ полиндромом!");