﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

int num;
Console.Write("Введите целое число: ");
if (int.TryParse(Console.ReadLine(), out num))
    if (num % 2 == 0) Console.Write("Да");
    else Console.Write("Нет");
else Console.Write("Не число");
