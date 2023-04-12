// Задача 18.
// написать програму, которая по заданному номеру четверти будет показывать диапазон возможных координат точек в этой четверти.

// Console.WriteLine("Введите координаты точки");
// Console.Write("X: ");
// int xCoordinate = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yCoordinate = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter(xCoordinate, yCoordinate);
// string result = quarter > 0
//                 ? $"Указанные координаты соответствуют четверти -> {quarter}"
//                 : "Введены некорректные координаты";

// Console.WriteLine(result);

// int Quarter (int x, int y)
// {
//     if(x > 0 && y > 0) return 1;
//     if(x < 0 && y > 0) return 2;
//     if(x < 0 && y < 0) return 3;
//     if(x > 0 && y < 0) return 4;
//     return 0;
// }


Console.WriteLine("Введите номер четверти");
string numQuart = Console.ReadLine();

string result = Quarter(numQuart);
Console.WriteLine(result);

string Quarter(string numQuarter)
{
    if(numQuarter == "1") return "x > 0 y > 0";
    if(numQuarter == "2") return "x < 0 y > 0";
    if(numQuarter == "3") return "x < 0 y < 0";
    if(numQuarter == "4") return "x > 0 y < 0";
    return "НЕТ таковой четверти !! ";
}
