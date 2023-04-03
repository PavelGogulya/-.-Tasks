
// // Задача 22: Напишите программу, которая принимает на вход число (N) 
// // и выдаёт таблицу КУБОВ чисел от 1 до N.


int GetUserData()
{
    int userNumber;

    Console.WriteLine("Введите число");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out userNumber))
        {
            if (userNumber <= 0)
            {
                Console.WriteLine("Введите число больше 0");
                Console.WriteLine("натуральное цельное число!!");
                continue;
            }
            else break;
        }

        Console.WriteLine("Введите число, а не строку!");
        Console.WriteLine("Здесь ИнфорМатПрограммирование, а не урок руссокого!");
    }

    return userNumber;
}



void Square(int userNumber)

{ Console.WriteLine("----------------");
    for (int i = 1; i <= userNumber; i++)
    {
        
        int stepen = 3;
        Console.WriteLine($" | {i,3} | {Math.Pow(i, stepen),5}|");
        Console.WriteLine("----------------");
        }

}

Square(GetUserData());

