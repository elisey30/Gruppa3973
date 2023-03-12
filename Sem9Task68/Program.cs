// Задача № 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Печать результата 
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
// Метод вычисления функции Аккермана с помощью рекурсии.
int AkkermanFunction(int num1, int num2) 
{
    if (num1 == 0)
        return num2 + 1;
    else if (num1 > 0 && num2 == 0)
        return AkkermanFunction(num1 - 1, 1);
        return AkkermanFunction(num1 - 1, AkkermanFunction(num1, num2 - 1));
   
}

int numberM = ReadData("Введите неотрицательное число М: ");
int numberN = ReadData("Введите неотрицательное число N: ");
int res = AkkermanFunction(numberM,numberN);
PrintData("A(m,n) = " +res);