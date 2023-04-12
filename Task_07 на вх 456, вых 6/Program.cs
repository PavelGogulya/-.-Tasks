// Задача 7
// Прога которая выдает последнюю цифру от введнного пользователем 3х значного числа. 
// 456 -> 6
// 782 -> 2

Console.WriteLine("введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999) // Условие проверки трехзначности
{
    int lastNumber = number %10;
    Console.WriteLine($"последняя цифра числа {lastNumber}"); //вычисление работает 
}
else
Console.WriteLine ($" число {number} не трехзначное!");