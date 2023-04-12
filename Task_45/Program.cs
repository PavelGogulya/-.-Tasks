// See https://aka.ms/new-console-template for more information
Console.WriteLine("World!");


Задача 45

Console.WriteLine($"Введите  число N:");
int n = Convert.ToInt32(Console.ReadLine());

PrintArray(FibboNumbers(n));

int[] FibboNumbers(int num)
{
    int[] fibboArray = new int[num];
    // fibboArray[0]=0;
    fibboArray[1]=1;
    for (int i = 2; i < num; i++)
    {
       fibboArray[i]=fibboArray[i-1]+fibboArray[i-2];
    }
    return fibboArray;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i], 1}; ");
        else Console.Write($"{arr[i], 1}");
    }
    Console.Write("]");
}