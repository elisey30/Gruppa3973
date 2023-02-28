// Задача №35
// Задайте одномерный массив из 123 случайных чисел
// Найдите колличество элементов массива значение которых 
// лежит в отрезке от 10 до 99

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
//Метод который ищет количество элементов в отрезке от 10 до 99
int NumElemInRange (int[] arr, int min, int max)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > min && arr[i] < max) res++;
    }
    return res; 
}
//Обращаемся к методу Gen1DArr, где указываем длину массива макс и мин значение
int[] mass = Gen1DArr(123,-100,100);
Print1DArr(mass);

WriteMess($"{NumElemInRange(mass,10, 99)}");