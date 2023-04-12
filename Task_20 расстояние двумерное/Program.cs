// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5.09;
// A (7,-5); B (1,-1) -> 7.21;

// double d = Math.Sqrt(5);
// double num = 5.094774638;
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero); // у меня получилось нужное 5,09 и без параметра `MidpointRounding`, 
// Console.WriteLine(numRound);
// Как возможно сделать через форматирование вывода ?


Console.WriteLine("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double findingDistance = FindDistance(x1, x2, y1, y2);

Console.WriteLine ($"Расстояние между точками А и Б = {Math.Round(findingDistance ,2, MidpointRounding.ToZero)}");

double FindDistance(int x1, int y1, int x2, int y2)

{
    int firstCatet = x2 - x1;
    int secondCatet = y2 - y1;
    double distance = Math.Sqrt((firstCatet * firstCatet) + (secondCatet * secondCatet)); // C = корень квадратный (A*A + B*B)
    return distance;   
}
