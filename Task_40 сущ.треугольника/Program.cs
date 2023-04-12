// Задача 40: 
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите длину стороны");
int firstSide = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны");
int secondSide = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны");
int thirdSide = Convert.ToInt32(Console.ReadLine());

bool result = IsTriangle(firstSide, secondSide, thirdSide );
string res = resalt? " С данными стронами получим Треугольник": С данными стронами Е сущ. треугольника": // '?' и ':' тернарный ператор
Console.WriteLine(res);

bool IsTriangle (int num1, int num2, int num3)
{
    return num1<num2+num3 && num2<num1+num3 && num3<num1+num2 ;
}

