/* Написать прогу, которая на вход принимает число и выдает его квадрат
4 -> 16
-3 -> 9
-7 -> 49 */


// Console.WriteLine("Введите целое число"); // Приглашение от программы на ввод данных

// int number = Convert.ToInt32(Console.ReadLine()); // Данный оператор 'Console.ReadLine()' строчного типа,
// // поэтому зачастую его преобразуем. Это делается оператором 'Convert.ToInt32'

// /* ЛИБО string str = Console.ReadLine();
// int number = Convert.ToInt32(str); */

// int squareNumber = number * number;
// Console.WriteLine($"Квадрат числа {number} = {squareNumber}"); //  знак '$' есть интерполяция строк. 
// //т.е в '{}' фигурных скобках выводится ЗНАЧЕНИЕ пременных а не их название как текст

Console.WriteLine ("ВВедите целое число");
// string (str) = Console.ReadLine();
// int number = Convert.ToInt32(str);
int number = Convert.ToInt32(Console.ReadLine());
int squareNumber = number * number;
Console.WriteLine(squareNumber);
Console.WriteLine($"квадрат числа {number} равен {squareNumber}");

// Если интеллектуально (когда печатаешь программу) НЕ подтягиваются значения из расширения (команды, операторы и т.д.)
//  нужно перезапустить расширение C#.

//  Делается это командой клавиш Shift+Ctr+P или F1, тогда попадаем в строку поиска программы "VS code", где набираем 'Restart OmniSharp' !!


