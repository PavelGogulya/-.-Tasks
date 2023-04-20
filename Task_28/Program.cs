// Задача 28: Напишите программу, которая
// принимает на вход число A и выдаёт
// произведение чисел от 1 до A. (натуральные числа)
// 4 -> 24
// 5 -> 120



//                  Павел Аверин

Console.WriteLine("Введите целое положительное число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 0)
{
    int result = Factorial(numberA);
    Console.WriteLine($"Результат вычисления факториала: {result}");
}
else Console.WriteLine("Введено отрицательное число!");

int Factorial(int num) // int num = number
{
    int resultFactorial = 1;
    for(int i = 1; i <= num; i++)
    {
        checked // проверка полученного результата на переполнения типа
        {
            resultFactorial *= i;
        }                               // sum += i/ Хотя фигурные скобки '{}' можем опустить, поскольку одно действие
    }
    return resultFactorial;
}




// Square(GetUserData());

// int userNumber;

//     Console.WriteLine("Введите число");
//     while (true)
//     {
//         if (int.TryParse(Console.ReadLine(), out userNumber))
//         {
//             if (userNumber <= 0)
//             {
//                 Console.WriteLine("Введите пожалуйста больше 0");
//                 continue;
//             }
//             else break;
//         }

//         Console.WriteLine("Введите число, а не строку!");
//     }

// int Counter(int userNumber)
// {
//     int i = 0;

//     while(userNumber != 0)
//     {
//         i++;
//         userNumber /= 10;
//     }
//     return i;
// }
// int userNumber = GetUserData();

// Console.WriteLine("Введите целое положительное число");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if(numberA>0)
// {
//     int result = Factorial(numberA);
//     Console.WriteLine($"Результат вычисления факториала : {result}");
// }
// else Console.WriteLine($ "Введено отрицательное число!");

// int Factorial(int num); // int num = number

// {
//     int resultFactorial = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         checked
//         {
//             resultFactorial *= i;
//         }
//     }
//     ret
// }
// int