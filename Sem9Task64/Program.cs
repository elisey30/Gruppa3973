// Задача № 64
// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"

// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Метод который находит все натуральные числа от 1 до N с помощью рекурсии
void StringRecursion(int num)
{
    if (num == 0) return;
    StringRecursion(num - 1);
    Console.Write($"{num} ");
}


int test = ReadData("Введите число: ");
StringRecursion(test);
