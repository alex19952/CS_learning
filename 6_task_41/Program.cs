// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int M = 7;
int[] arr = new int[M];
for (int i = 0; i < 7; ++i) {
    arr[i] = int.Parse(Console.ReadLine());
}
int count = 0;
foreach (var item in arr)
{
    if (item > 0) count++;
}
Console.WriteLine(count);