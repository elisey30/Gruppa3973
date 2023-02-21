﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом


// Метод считывает данные от пользователя
int ReadInput(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine()?? "0");
}
// Метод который принимает данные пользователя с переменной num, 
//вторая переменная pow для накапливания кубов
string LineBuilder(int num, int pow)
{
    //Принимаем пустую переменную
    string res = String.Empty;
    // Проходим от одного до num и увеличивая на один
    for(int i = 1; i<=num; i++)
    {
        // Накапливаем в переменную числа через пробел
        res = res + Math.Pow(i,pow)+"\t";
    }
    //Возвращаем полученный результат
    return res;
}
// Вводим переменную и обращаемся к методу ReadInput
int N = ReadInput("введите число: ");
// Выводим на консоль число пользователя и от одного до N
Console.WriteLine(LineBuilder(N,1));
// Выводим на консоль в таблице кубов
Console.WriteLine(LineBuilder(N,3));