/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int num_1, num_2;
Console.Write("Ведите 1-е число: ");
int.TryParse(Console.ReadLine(), out num_1);
Console.Write("Ведите 2-е число: ");
int.TryParse(Console.ReadLine(), out num_2);
Console.Write("Наибольшее число: ");
Console.Write(Math.Max(num_1, num_2));
