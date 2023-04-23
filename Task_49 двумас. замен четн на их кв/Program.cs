// Задача 49
// Задайте двумерный массив.
// Найдите элементы у которых оба индекса четные, и замените эти элементы на их квадраты. 

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

Console.WriteLine("Исходный массив");

void PrintMatrix(int[,] matrix) //  метод void поскольку массив ничего не должен возвращать в консоль, он пустой
{
    for (int i = 0; i < matrix.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j = j + 2)
        {
            if ([i,j] /= %)
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine();
    }

}

int[,] array2d = CreateMatrixRndInt(5, 5, -9, 9);
PrintMatrix(array2d);

// Console.WriteLine("Массив с квадратами элементов у которых четные индексы");

// void PrintMatrixSquare(int[,] matrix) //  метод void поскольку массив ничего не должен возвращать в консоль, он пустой
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         //Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j], 6}");
//         }
//         Console.WriteLine();
//     }

// }
// int[,] arraySquare = CreateMatrixRndInt(3, 4, -100, 100);
// PrintMatrix(arraySquare);
