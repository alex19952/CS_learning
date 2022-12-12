// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void print (String[] str) {
    Console.Write("[");
    for (int i = 0; i < str.Length - 1; i++) {
        Console.Write(str[i].Replace(" ","") + ", ");
    }
    Console.Write(str.Last() + "]");
}

String[] str = Console.ReadLine().Split(',');
print(str);