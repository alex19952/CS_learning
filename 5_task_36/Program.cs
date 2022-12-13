// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int foo(List<int> list) {
    int result = 0;
    for (int i = 0; i < list.Count; i += 2) {
        result += list[i];
    }
    return result;
}

List<int> list = new List<int>();
Random rnd = new Random();
for (int i = 0; i < rnd.Next(1, 50); i++) {
    list.Add(rnd.Next(-100, 101));
}

Console.Write(foo(list));