// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84;
// A (7,-5,0); B (1,-1,9) -> 11.53;


Console.WriteLine("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double faindingDistance = FaindDistance(x1, y1, z1, x2, y2, z2); 

Console.WriteLine($"Расстояние между точками А и Б = {faindingDistance}");

double FaindDistance(int x1Coordinata, int y1Coordinata, int z1Coordinata, int x2Coordinata, int y2Coordinata, int z2Coordinata)
// Метод поиска гипотенузы (расстояния меж.точками) с округлением

{
    int firstCatet = x2Coordinata - x1Coordinata;
    int secondCatet = y2Coordinata - y1Coordinata;
    int thirdCatet = z2Coordinata - z1Coordinata;
    double distance = Math.Sqrt((firstCatet * firstCatet) + (secondCatet * secondCatet) + thirdCatet*thirdCatet);
    distance = Math.Round(distance, 2, MidpointRounding.ToZero);
    return distance;
}
