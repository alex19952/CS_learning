// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double foo(List<double> list) {
    double max = list[0];
    double min = list[0];
    foreach (var item in list) {
        if (item > max) max = item;
        if (item < min) min = item;
    }
    return max - min;
}

List<double> list = new List<double>();
Random rnd = new Random();
for (int i = 0; i < rnd.Next(1, 11); i++) {
    list.Add(rnd.NextDouble() * rnd.Next(-100, -101));
}

Console.Write(foo(list));