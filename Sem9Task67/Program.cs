// Задача № 67
// Напишите программу кторорая принимает на вход число,
// и возвращает сумму этого числа.

// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Печать результата 
void PrintData(int msg)
{
    Console.WriteLine(msg);
}
// Метод который возвращает сумму этих чисел
int RecSumDig(int num)
{
    if(num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + RecSumDig(num/10);
    }
}

int test = ReadData("Введите число:  ");
int res = RecSumDig(test);
PrintData(res);