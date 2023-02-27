// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// *Сделать оценку времени алгоритма через числа и строки



//Метод ввода данных 
int ReadDate(string msg) 
{ 
    Console.WriteLine(msg); 
    return int.Parse(Console.ReadLine() ?? "0"); 
} 
//Метод вывода данных пользователя 
void PrintData(string msg, double val) 
{ 
    Console.WriteLine(msg + val); 
} 
//Вычисляем сумму числел введеных пользователем  
int n = ReadDate("Введите число: "); 
int sum = 0; 
while (n != 0) 
{ 
    sum += n%10; 
    n /= 10; 
} 
 
PrintData("Сумма чисел ", sum);