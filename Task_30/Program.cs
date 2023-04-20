// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int SumNumbers(int num) 
// int[] array = new int[8] // 0 1 2 3 4 5 6 7
//int[]
// array[i] = 45;
// array[i] = 57;
// System.Console.WriteLine(array[i]); // команда WriteLine выводит только конкретные индексы массива, весь массив команда не выведет !

// int[] array = new int[8];

// FillArray(array); // здесь просто вызываем метод поскольку он НЕ возвращает никаких значений
// // ,а если бы был возвращаемый тип массива тогда нужно было бы создать переменную этого типа и в нее записывать результат 
// Console.WriteLine("Массив из 8 элементов, заполненный 0 и 1:");
// PrintArray(array);

// void FillArray(int[] userArray) // void потому что в данном месте мы НЕ просим вывести данные на экран
// {
//     Random num = new Random();
//     for (int i = 0; i < userArray.Length; i++)
//     {
//         userArray[i] = num.Next(0, 2); 
//     }
// }

// void PrintArray(int[] user2Array) //тип массива 'Void' потому что МАссивы передаютя в методы по ссылке, 
// // а если будем создавать массив внутри метода, то тип будет иной (int, double)
// // А если возвращаемый тип массива то тип массива 'Int'
// // если работатете в  методе с готовым массиво, то возвращать его НЕ нужно и потому 'void'
// {

//     Console.Write("[");
//     for (int i = 0; i < user2Array.Length; i++) //  здесь использован цикл For
//     {
//         if (i == user2Array.Length - 1) // условие: если это последний элемент массива то НЕ ставим запятую
//         {
//             Console.Write($"{user2Array[i]} ");
//         }
//         else Console.Write($"{user2Array[i]}, "); // иначе ставим запятую
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }


// int [] array = new int[8]; // создаем переменную типа массив '[]' с типом целых данных 'int'  и названием 'array'
// //       поскольку 8 элементов, то это соответсвует 1 2 3 ... 7 (семи ) индексам

// array[4] = 45;
// array[9] = 57; // здесь 57 не увидим, программа выдаст ошибку поскольку индекс '9' за пределами размера массива (последний индекс был 7)

// array[4] = 45;
// array[9] = 57;

// System.Console.WriteLine(array[i]);

// вариант от Ольги Паскаль

// int[] array =  new int[8];

// FillArray(array);
// PrintArray(array);

// void FillArray(int[] userArray)
// {
//     for (int i = 0; i < userArray.Length; i++)
//     {
//         userArray[i] = new Random().Next(0, 2);// поскольку последнее число не входит диапазон 'Next' (а нам нужны 0 и 1),
//  то конец интервала указывавем на единицу больше т.е '2'.
// Также в этом методе НЕ рационально создавать метод Random каждый раз как заходим в цикл, на это тратится уйма памяти!
// Целесообразнее его обозначить перед циклом 'for'
//     }
// }

// void PrintArray(int[] userArray) // в круглых скобках пишется аргумент. т.е. 'int[] userArray' есть аргумент
// {
//     Console.WriteLine("Массив из 8ми элементов, заполненный 0 и 1:"); // данная строка привязывает метод к конкретной задаче, 
// метод теряет универсальность.
//     Console.Write("[");
//     for (int i = 0; i < userArray.Length; i++)
//     {
//         Console.Write($"{userArray[i]},");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// решение проблемы от Булгакова Андрея

int[] array = new int[8];

FillArray(array); 
Console.WriteLine("Массив из 8 элементов, заполненный 0 и 1:");
PrintArray(array);

void FillArray(int[] userArray) 
{
    // Random num = new Random();
    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = new Random().Next(0, 2); 
    }
}

void PrintArray(int[] user2Array) 
{
    Console.Write("[");
    for (int i = 0; i < user2Array.Length; i++) 
    {
        if (i == user2Array.Length - 1) 
        {
            Console.Write($"{user2Array[i]} ");
        }
        else Console.Write($"{user2Array[i]}, "); 
    }
    Console.Write("]");
    Console.WriteLine();
}