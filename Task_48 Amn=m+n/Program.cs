// Задача 48.
// создать двумерный масcив размера m и n, в котором каждый элемент в массиве находится по формуле Amn=m+n.
// Выведите полученный результат на экран
// m = 4, n = 3
//  1 2 3 4
//  1 2 3 4 
//  2 3 4 5 


Console.WriteLine("Введите колличество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов и таблицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m,n);
PrintMatrix(resultArray);
Console.WriteLine();

int[ , ] CreateArrayMatrix(int userM, int userN) 
{
    int[ , ] matrix = new int[userM,userN];
 
    for (int m = 0; m < matrix.GetLength(0); m++)
    {    
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m,n] = m+n;
        }   
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) //  метод void поскольку массив ничего не должен возвращать в консоль, он пустой
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
 //           Console.Write($"{matrix[m, n]}");
            if (m<matrix.Length - 1) Console.Write($"{matrix[m,n], 3}");
            else Console.Write($"{matrix[m, n]}");
        }
        Console.WriteLine();
    }
}

