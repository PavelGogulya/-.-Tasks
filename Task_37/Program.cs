// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

////////////////////////////// от Аверина Павла

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray (int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//        else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }

// int[] CreateNewModifiedArray(int[] arr)
// {
//     int size = arr.Length / 2;
//     if (arr.Length % 2 == 1) size = size + 1;
//     int[] resultArray = new int[size];
     
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         resultArray[i] = arr[i] * arr[arr.Length - 1 - i];
//     }
//      if (arr.Length % 2 == 1) resultArray[size-1]=arr[size-1];
//     return resultArray;
       
// }
// int[] array = CreateArrayRndInt(5, 1, 9);
// Console.WriteLine("Исходный массив:");
// PrintArray(array);
// Console.WriteLine();
// int[] resultArray = CreateNewModifiedArray(array);
// PrintArray(resultArray);

/////////////////////////// от Игоря

int[] CreateNewPare(int[] arr)
{
    int size = arr.Length / 2;
    
    if(arr.Length % 2 != 0)
    {
        size += 1;
    }

    int[] pare = new int[size];
    
    for (int i = 0; i < pare.Length; i++)
    {
        pare[i] = arr[i] * arr[arr.Length -1 - i];
    }       // 1 2 4 7 76 8 3

    if(arr.Length % 2 != 0) 
        pare[pare.Length - 1] = arr[arr.Length / 2];
    
    return pare;
}

Console.WriteLine("Произведение пар чисел:");
PrintArr(CreateNewPare(arr));



