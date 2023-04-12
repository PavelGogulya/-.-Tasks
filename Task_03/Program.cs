// Задача 3
// Напишите программу, которая проверяет день недели.

// если не подсвечивабстя команды и ошибки, нет интеллектуального ввода команд и оперторов то нужно перезапустить расширение Omni Sharp
// Выполняется это через команду в строке: 'F1' или сочетанием 'Ctrl+Shift+P' заходим в поиск(строку) Git и набираем 'Restart' Omni Sharp

Console.WriteLine("Введите число, которому соответсвует день недели");
string day = Console.ReadLine();
if (day == "1")
{ 
    Console.WriteLine("Понедельник!");
}
else if (day == "2")
{ 
    Console.WriteLine("Вторник!!");
}
else if (day == "3")
{ 
    Console.WriteLine("Среда!!!");
}
else if (day == "4")
{ 
    Console.WriteLine("Четверг-Семинар в 10 утра!!!");
}
else if (day == "5")
{ 
    Console.WriteLine("Пятница - бадминтон!!!!!");
}
else if (day == "6")
{ 
    Console.WriteLine("Суббота - Лекция в 12");
}
else if (day == "7")
{ 
    Console.WriteLine("Воскресенье - Семейный день!");
}
else
{
    Console.WriteLine ("Не является днем недели. В нашем юлианском календаре 7 !Семь! дней недели");
}
