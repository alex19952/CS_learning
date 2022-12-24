// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Random ran = new Random();

int n = ran.Next(3,11);
int m = ran.Next(3,11);
int[,] arr = new int[n,m];
for (int i = 0; i < n; i++) {
    for (int j = 0; j < m; j++) {
        arr[i,j] = ran.Next(-50,51);
    }
}
for (int i = 0; i < n; i++) {
    for (int j = 0; j < m; j++) {
        Console.Write(arr[i,j]);
        Console.Write("\t");
    }
    Console.WriteLine();
}