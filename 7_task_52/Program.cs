// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arr = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

int rows = arr.GetUpperBound(0) + 1;
int columns = arr.Length / rows;

for (int col = 0; col < columns; col++) {
    double sum = 0;
    for (int ro = 0; ro < rows; ro++) {
        sum += arr[ro,col];
    }
    Console.WriteLine(sum / rows);
}   