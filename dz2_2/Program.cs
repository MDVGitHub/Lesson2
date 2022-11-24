/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.WriteLine("Введите число в фомате "1234"");
int Number = Convert.ToInt32(Console.ReadLine());
if
    (Number/100 < 1) 
    Console.WriteLine("третьей цифры нет");
else
    if
        (Number / 1000 > 0)
        Console.WriteLine($"Третья цифра {Number / 10 % 10}");
    else
        Console.WriteLine($"Третья цифра {Number % 10}");