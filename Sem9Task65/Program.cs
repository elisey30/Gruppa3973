// Задача № 65
// Задайте значение от n до m, напишите программу которая
// найдет все натуральные элементы в промежутке от n до m.

// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Печать результата 
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}
// Метод который находит все натуральные элементы в промежутке от n до m.
string RecMN(int m, int n)
{
    string res = string.Empty;
    if(m>=n)
    {
        res = n.ToString();
    }
    else
    {
        res=res + m + " " + RecMN(m+1,n);
    }
    return res;
}

int number1 = ReadData("Введите число М: ");
int number2 = ReadData("Введите число N: ");
string resultLine = RecMN(number1,number2);
PrintResult(resultLine);