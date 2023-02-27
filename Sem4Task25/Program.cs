// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// *Написать калькулятор с операциями +, -, /, * и возведение в степень

//Метод который счытывает данные у пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()?? "0");
}
// Метод выводит данные пользователя
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}
//Метод который возводит число А в натуральную степень числа В
long Pow(int a, int b)
{
    long res = 1;
    while(b > 0)
    {
        res = res*a;
        b = b-1;
    }
    return res;
}


//Обращение к методу ReadData 
int a = ReadData("Введите число А: ");
int b = ReadData("Введите чосло В: ");
//Обращение к методу Pow
long res = Pow(a,b);
//Обращение к методу ReadData
PrintData("Число А в натуральной степени числа В: ", res);