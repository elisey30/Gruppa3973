// Задача 34
//Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//* Отсортировать массив методом пузырька
//* Отсортируйте массив методом подсчета
//* Сравнить скорость работы метода пузырька и вставки


//Метод генерации рандомный чисел с корректировкой входных данных
int[] Gen1DArr(int len, int min, int max)
{
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
//Метод вывода обрамления
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}
//Метод вывода данных
void WriteMess(string msg)
{
    Console.WriteLine(msg);
}
//Метод который ищет колличество четных чисел в массиве
int EvenSum(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2  == 0)
        {
            res = res + 1;
        }

    }
    return res;
}
//Обращаемся к методу Gen1DArr, где указываем длину массива макс и мин значение
int[] mess = Gen1DArr(5, 100, 120);
Print1DArr(mess);

int num = EvenSum(mess);
WriteMess($"Сумма положительных чисел: = {num}");

