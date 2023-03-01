// Задача 38
// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
//Отсортируйте массив методом вставки



//Метод генерации вещественных рандомных чисел с корректировкой входных данных
double[] Gen1DArr(int len, int min, int max)
{
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min,max) + rnd.NextDouble();
    }
    return array;
}
//Метод вывода обрамления
void Print1DArr(double[] arr)
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
//Метод который находит разницу между максимальным и минимальным элементов массива
double MaxMin (double[] arr)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min );
}
//Обращаемся к методу Gen1DArr, где указываем длину массива макс и мин значение
double[] mess = Gen1DArr(5, 10, 20);
Print1DArr(mess);

double num = MaxMin(mess);
WriteMess($"Разница между элементами: = {num}");

