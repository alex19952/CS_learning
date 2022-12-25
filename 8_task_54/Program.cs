// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] arr = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};


int rows = arr.GetUpperBound(0) + 1;
int columns = arr.Length / rows;

for (int r = 0; r < rows; r++) {
    int[] temp = new int[columns];
    for (int c = 0; c < columns; c++) {
        temp[c] = arr[r,c];
    }
    Array.Sort(temp, (x, y) => y.CompareTo(x));
    for (int c = 0; c < columns; c++) {
        arr[r,c] = temp[c];
        Console.Write($"{arr[r,c]} ");
    }
    Console.WriteLine();
}

