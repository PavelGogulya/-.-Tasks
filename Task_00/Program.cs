/* Написать прогу, которая 
1 на вход принимает число и 
2  выдает его квадрат
4 -> 16
-3 -> 9
-7 -> 49 */


Console.WriteLine("Введите целое число");

int number = Convert.ToInt32(Console.ReadLine());

/* ЛИБО string str = Console.ReadLine();
int number = Convert.ToInt32(str); */

int squareNumber = number * number;
Console.WriteLine($"Квадрат числа {number} = {squareNumber}");

