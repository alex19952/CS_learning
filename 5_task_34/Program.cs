// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int foo(List<int> list) {
    int result = 0;
    foreach (var item in list) {
        if (item % 2 == 0) result++;
    }
    return result;
}

List<int> list = new List<int>();
Random rnd = new Random();
for (int i = 0; i < rnd.Next(1, 50); i++) {
    list.Add(rnd.Next(100, 1000));
}

Console.Write(foo(list));