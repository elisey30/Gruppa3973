// Задача №28
// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.


using System.Numerics;
// Метод считываем данные с пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ??"0");
}
//Метод вывода результата
void PrintData(string msg, BigInteger num)
{
    Console.WriteLine(msg+num);
} 
// Метод нахождения факториала
BigInteger FactorCalc(int num)
{
    BigInteger res = 1;
    for(int i=1; i<=num; i++)
    {
        res = res*i;
    }    
        return res;
    
}

//Обращение к методу ReadData 
int num = ReadData("Введите число: ");
//Обращение к методу нахождению факториала числа N
BigInteger res = FactorCalc(num);
// Обращение к методу вывода результата
PrintData("Вывод результата: ", res);