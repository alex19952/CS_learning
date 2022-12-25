// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//  будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] arr = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};


int rows = arr.GetUpperBound(0) + 1;
int columns = arr.Length / rows;

int[] sums = new int[rows];

for (int r = 0; r < rows; r++) {
    int sum = 0;
    for (int c = 0; c < columns; c++) {
        sum += arr[r,c];
    }
    sums[r] = sum;
}

Console.WriteLine($"{Array.IndexOf(sums, sums.Max())} строка");
