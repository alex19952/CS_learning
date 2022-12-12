// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N;
if (int.TryParse(Console.ReadLine(), out N)) {
    if (N > 0) {
        int[] result = null;
        for (int i = 1; i < N; i++) {
            Console.Write(i*i*i + ", ");
        }
        Console.Write(N*N*N);
    }
}
