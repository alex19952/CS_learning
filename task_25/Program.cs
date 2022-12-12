// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double foo (int A, int B) {
    return Math.Pow(A, B);
}

int A, B;
if (int.TryParse(Console.ReadLine(), out A) & 
    int.TryParse(Console.ReadLine(), out B)) {
    Console.Write(foo(A,B));
}
