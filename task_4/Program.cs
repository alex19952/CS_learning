/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int num_1, num_2, num_3;
Console.Write("Введите 3 целых числа: ");
string[] str = Console.ReadLine().Split(' ');
if (str.Count() == 3) {
    int.TryParse(str[0], out num_1);
    int.TryParse(str[1], out num_2);
    int.TryParse(str[2], out num_3);
    Console.WriteLine(Math.Max(Math.Max(num_1, num_2), num_3));
}
else Console.WriteLine("ой");
