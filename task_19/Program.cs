// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
string str = Console.ReadLine();
if (int.TryParse(str, out int num)){
    bool flag = false;
    for (int i = 0; i < str.Length / 2; i++) {
        if (str[i] != str[str.Length - i - 1]) {
            Console.Write("Нет");
            flag = true;
            break;
        }
    }
    if (!flag) Console.Write("Да");
}
