﻿Console.WriteLine("Введите цифру, обозначающую день недели (1 - понедельник, 2 - вторник, 3 - среда, 4 - четверг, 5 - пятница, 6 - суббота, 7 - воскресенье): ");
int a = int.Parse(Console.ReadLine() ?? "0");
if (a <= 5)
Console.WriteLine($"Этот день недели не является выходным");
else if (a > 7)
Console.WriteLine($"Такого дня недели не существует");
else
Console.WriteLine($"Этот день недели - выходной");