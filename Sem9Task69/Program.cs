// Задача № 69
// Напишите программу, которая будет принимать два числа а,в
// и она возведет а в степень в с помощью рекурсии.

// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Печать результата 
void PrintData(long msg)
{
    Console.WriteLine(msg);
}
// Метод который возводит А в степень В с помощью рекурсии
long RecPow(int a, int b)
{
    if( b <= 1) return a;
    return a * RecPow(a,b-1);
}

int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");
long res = RecPow(numberA,numberB);
PrintData(res);