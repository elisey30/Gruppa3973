// Задача № 42
// Напишите программу которая будет преобразовывать десятичное 
// число в двоичное


// Метод считываем данные с пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ??"0");
}
//Метод вывода результата
void PrintData(string msg, string num)
{
    Console.WriteLine(msg+num);
} 
// Метод который преобразовывает десятичное число в двоичное
string DecToBin(int num)
{
    string res = string.Empty;
    while(num>0)
    {
        res = num % 2 + res;
        num = num/2; 
    }
    return res;
}

int mess = ReadData("Введите число; ");
PrintData("Число в двоичной системе будет равно: ", DecToBin(mess));

