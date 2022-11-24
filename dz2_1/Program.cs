/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Console.WriteLine("Введите число");
int Number1 = Convert.ToInt32(Console.ReadLine());
string Number2 = Convert.ToString(Number1);
Console.WriteLine($"Второй символ введенного числа это:" +Number2[1]);
