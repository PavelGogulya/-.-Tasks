// 9. Напишите программу, которая выводитслучайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int numberRandom = new Random().Next(10, 100); // в програмировании используется полу интервал. 
// т.е последнее число не берется в работу, поэтому  мы заведомо  конец интервала увеличили на единицу
Console.WriteLine($"случайное число из отрезка 10-99 => {numberRandom}");

// int firstDigit = numberRandom / 10;
// int secondDigit = numberRandom % 10;

// if (firstDigit > secondDigit) // ?
// {
//     Console.WriteLine($"наибольшая цифра числа - {firstDigit}");
// }
// else // :
//     Console.WriteLine($"наибольшая цифра числа - {secondDigit}");

// int number2 = Math.Max(firstDigit, secondDigit); ВАриант записи решения через оператор Math.Max,
// Console.WriteLine(number2); который сразу отсекает вариант чисел с одинаковыми цифрами (например: 55, 33, 88)

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;  // вариант решения  с использованием Тернарного оператора
// Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");

// Методы это есть функции и бывают двух видов
// процедуры - метод, который не возвращает значения (например 'Void')
// функции - метод, который возвращает значения (например 'Next')

int maxDigit = MaxDigit (numberRandom);
Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");


int MaxDigit (int numRandom) // тип данных|имя метода| новая переменная|. numRandom = numberRandom
{
    int firstDigit = numRandom / 10;
    int secondDigit = numRandom % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit; // команда возврата метода
}