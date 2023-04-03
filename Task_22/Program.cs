// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 ->1,4,9,16,25
// 1 -> 1
// 2 -> 4
// ...
// 7 -> 49

//                  РЕШЕНИЕ от Аверьянова Павла

string Spreadsheet(int nNum) //  строка 'ЭлектроннаяТаблица, хотя можно и Table
{
    string spreadsheetResult = "___________ \n"; // string.Empty; пустая строка
    for (int i = 1; i <= nNum; i++)
    {
        spreadsheetResult = spreadsheetResult + $"| {i,3}  |  {i * i,5} | \n"; // управляющий символ '/n' - "возврат каретки" 
       // т.е переход на новую строку. '3 и 5' - кол-во клеток внутри фигурных скобок для выравнивания (форматирования)
    }
    spreadsheetResult = spreadsheetResult + "-----------";
    return spreadsheetResult;
}

Console.Write("Введите число nNum:");
int n = Convert.ToInt32(Console.ReadLine());

string result = Spreadsheet(n);
Console.WriteLine(result);


// //                         РЕШЕНИЕ от Игоря

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

// void Square(int userNumber)
// {
//     for (int i = 1; i <= userNumber; i++)
//     {
//         Console.WriteLine($"|{i,3} | {i * i,3}|");
//     }
// }

// Square(GetUserData());
