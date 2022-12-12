// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sum_nums(List<int> nums) {
    int result = 0;
    foreach (int item in nums) {
        result += item;
    }
    return result;
}

List<int> split_num (string str) {
    List<int> nums = new List<int>();
    foreach (var item in str) {
        nums.Add(item - '0');
    }
    return nums;
}

string str = Console.ReadLine();
if (int.TryParse(str, out int temp)) {
    Console.Write(sum_nums(split_num(str)));
}
