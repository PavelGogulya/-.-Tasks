// Задача 46.
// Залдайте двумерный массив размером m*n, заполненный случайными числами

// m=3, n=4

// 
//          0   1   2   3   индексы

//  0       1   4   8   19
//  1       5   -2  33  -2
//  2       77  3   8   1

// int[ , ] CreateMatrixRndInt(int rows, int columns, int min, int max) // создаем ДВУМЕРНЫЙ массив со случайными натуральными числами.
// //                            rows строки(ряды), сolumns - столбцы (колонки)
// {
//                             // 0       1    индексы
//     int[ , ] matrix = new int[rows,columns]; // новый массив с размером строки столбцы
//     Random rnd = new Random(); //создаем объект Random посредством переменной rnd- она является ссылкой на объект Random

//     for (int i = 0; i < rows; i++) // по умолчанию внешний цикл работает по строкам
//         // либо for (int i = 0; i < matrix.GetLength(0); i++), т.е 3(три) строки 
//     {    
//         for (int j = 0; j < columns; j++) // по умолчанию внутренний цикл работает по столбцам
//         // либо for (int j = 0; j < matrix.GetLength(1); i++) т.е 4(четыре) столбца 
//         {
//             matrix[i,j] = rnd.Next(min, max + 1);
//         }   
//         // это есть вариант массива когда он проходит сначала по строкам, а внутри по столбцам
//     }
//     return matrix;

// а это  вариант массива когда он проходит СНАЧАЛА ПО СТОЛБЦАМ, а внутри(уже столбца) ПО СТРОКАМ
// int[ , ] matrix = new int[rows,columns]; 
//     Random rnd = new Random(); 

//     for (int j = 0; j < rows; j++) // здесь внешний цикл работает по столбцам
//         // либо for (int j = 0; j < GetLength(1); i++) т.е 4(четыре) столбца 
//     {    
//         for (int i = 0; i < columns; i++) // а внутренний цикл работает по строкам
//         // либо for (int i = 0; i < GetLength(0); i++) т.е 3(три) строки 
//         {
//             matrix[i,j] = rnd.Next(min, max + 1);

int[ , ] CreateMatrixRndInt(int rows, int columns, int min, int max) 
{
    int[ , ] matrix = new int[rows,columns];
    Random rnd = new Random(); 

    for (int i = 0; i < matrix.GetLength(0); i++)
    {    
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }   
    }
    return matrix;
}


void PrintMatrix(int[,] matrix) //  метод void поскольку массив ничего не должен возвращать в консоль, он пустой
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine("  |");
    }

}
int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
