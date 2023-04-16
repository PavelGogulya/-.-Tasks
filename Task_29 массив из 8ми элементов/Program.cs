// Задача 29: 
// Напишите программу, которая задаёт массив из 10 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 1, 33, 6]

int[] array = new int[10];

FillArray(array); 
Console.WriteLine("Массив из 10 элементов:");
PrintArray(array);

void FillArray(int[] userArray) 
{
    Random num = new Random();
    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = num.Next(0, 99);
    }
}

void PrintArray(int[] user2Array) 
{
    Console.Write("[");
    for (int i = 0; i < user2Array.Length; i++) 
    {
        if (i < user2Array.Length - 1) 
        {
            Console.Write($"{user2Array[i]}, ");
        }
        else Console.Write($"{user2Array[i]} финиш "); 
    }
    Console.Write("]");
    Console.WriteLine();
}
