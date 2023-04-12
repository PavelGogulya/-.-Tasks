// Задача 44: 
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите количество чисел Фибоначчи");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] fibArray = FibonachiNum(userNumber);
Console.WriteLine($"Первые {userNumber} чисел Фибоначчи: ");
PrintArray(fibArray);
Console.WriteLine();

int[] FibonachiNum(int num)
{
    int[] resultArray = new int[num];
    resultArray[0] = 0;
    resultArray[1] = 1;
    for (int i = 2; i < resultArray.Length; i++)
    {
        resultArray[i] = resultArray[i - 1] + resultArray[i - 2]; 
        // если i = 2, то 2-1 + 2-2 = 1+0 = 1
        // если i = 3, то 3-1 + 3-2 = 2+1 = 3
        // если i = 4, то 4-1 + 4-2 = 3+2 = 5
        // если i = 5, то 5-1 + 5-2 = 4+3 = 7
        // если i = 6, то 6-1 + 6-2 = 5+4 = 9
    }
    return resultArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }

}

// ++++++++++++
// Задача 44int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }

// int[] CopyArray(int[] array)
// {
//     int[] resultArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         resultArray[i] = array[i];
//     }
//     return resultArray;
// }

// int[] array = CreateArrayRndInt(12, 1, 99);
// Console.WriteLine("Исходный массив:");
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine("Копия:");
// int[] newCopyArray = CopyArray(array);
// newCopyArray[0]=-1;
// PrintArray(newCopyArray);