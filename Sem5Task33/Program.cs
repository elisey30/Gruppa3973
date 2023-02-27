// Задача № 33
// Задайте массив, напишите программу которая определяет
// присутствует ли заданное число в массиве.


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

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
} 
//Метод приема числа из консоли
int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
//Метод вывода данных
void WriteMess(string msg)
{
    Console.WriteLine(msg);
}
// Метод поиска заданного
bool SearchLen(int[]arr, int num)
{
    bool res = false;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            res = true; break;
        }
    }
    return res;
}
int []msg = Gen1DArr(12, -9, 9);
int searchNum = ReadInput("введите число для поиска в массиве: ");
Print1DArr(msg);

WriteMess(SearchLen(msg,searchNum)?"Данное число найдено: ": "Данное число не найдено: ");