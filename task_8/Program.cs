// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int num;
Console.Write("Введите целое число: ");
if (int.TryParse(Console.ReadLine(), out num)) 
    for (int i = 2; i <= num; i += 2) Console.Write(i + " ");
else Console.Write("Ошибка ввода");
