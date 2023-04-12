// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int SumNumbers(int num) 
// int []array = new int[8] // 0 1 2 3 4 5 6 7
//int[]
// array[i] = 45;
// array[i] = 57;
// System.Console.WriteLine(array[i]); // команда WriteLine выводит только конкретные индексы массива, весь массив команда не выведет !

int[] array = new int[8];

FillArray(array);
Console.WriteLine("Массив из 8 элементов, заполненный 0 и 1:");
PrintArray(array);

void FillArray(int[] userArray)
{
    Random num = new Random();
    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = num.Next(0, 2);
    }
}

void PrintArray(int[] user2Array) //тип массива 'Void' потому что МАссивы передаютя в методы по ссылке.
// А если возвращаемый тип массива то тип массива 'Int'
{

    Console.Write("[");
    for (int i = 0; i < user2Array.Length; i++) // цикл For
    {
        if (i == user2Array.Length - 1) // условие: если это последний элемент массива то НЕ ставим запятую
        {
            Console.Write($"{user2Array[i]} ");
        }
        else Console.Write($"{user2Array[i]}, "); // иначе ставим запятую
    }
    Console.Write("]");
    Console.WriteLine();
}