// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int num;
Console.Write("Введите номер дня недели: ");

if (int.TryParse(Console.ReadLine(), out num) & 0 < num & num < 8) {
    if (5 < num) Console.Write("Да");
    else Console.Write("Нет");
} else Console.Write("Введен не день недели");