﻿// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int num;
Console.Write("Введите целое число: ");

if (int.TryParse(Console.ReadLine(), out num)) 
    Console.Write((num / 10) % 10);
