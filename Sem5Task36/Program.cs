// Задача 36
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю


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
//Метод который ищет сумму элементов стоящих на не четных позициях
int OddSum (int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        res = res+arr[i];
    }
    return res; 
}
//Обращаемся к методу Gen1DArr, где указываем длину массива макс и мин значение
int[] mess = Gen1DArr(5,1,10);
Print1DArr(mess);

int num = OddSum(mess);
WriteMess($"Сумма чисел: = {num}");