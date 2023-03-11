// Задача № 63
// Задайте значение N, напишите программу которая
// выведет все натуральные числа в промежутке от N до 1
// выполнить с помощью рекурсии

// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Метод который ищет все натуральные числа от N до 1 с помощью рекурсии
void LineGenRec(int num)
{
    Console.Write(num + " ");
    if(num == 1)
    {
    }
    else
    {
        LineGenRec(num - 1);
    }
}

int number = ReadData("Введите число N: ");
LineGenRec(number);