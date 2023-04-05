// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int GetUserData()
// {
//     int userNumber;

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

//     return userNumber;
// }

// int CountNumbers(int num)
// {
//     int count = 0;
//     while(num>0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }
// Square(GetUserData());


// void Square(int userNumber)
// {
//     for (int i = 1; i <= userNumber; i++)
//     {
//         Console.WriteLine($"|{i,3} | {i * i,3}|");
//     }
// }
// Square(GetUserData());



//                  Паскаль Ольга

Console.WriteLine("Введите число:");
int UserNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int result = CountNumbers(UserNumber);
Console.WriteLine($"Колличество цифр в числе = {result}");

int CountNumbers(int num)
{
    int count = 0;
    while(num>0)
    {
        num = num/10;
        count++;
    }
    return count;
}