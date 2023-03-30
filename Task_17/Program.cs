/* 17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка. */

Console.WriteLine("Введите координаты точки:");
Console.WriteLine("x: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int Quarter (int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 1;
    if(x < 0 && y < 0) return 1;
    if(x > 0 && y < 0) return 1;
    return 0;
}