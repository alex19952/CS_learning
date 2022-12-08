// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

string num;
Console.Write("Введите целое число: ");
num = Console.ReadLine();

if (int.TryParse(num, out int temp) & num.Length > 3) {
    Console.Write(num[2]);
} else Console.Write("Третьей цифры нет");