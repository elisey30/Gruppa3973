// Задача №39
// Напишите программу которая перевернет одномерный масив 
// последний элемент будет на первом месте а первый на последним.


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
//Mетод вывода на печать с обрамлением
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}
//Метод разворачивания масива
void SwapArray(int[] arr)
{
    int bufElem = 0;
    for(int i = 0; i<arr.Length/2;i++)
    {
        bufElem = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] =  bufElem;
    }
}

int[] testArray = Gen1DArr(123,10,100);
Print1DArr(testArray);
SwapArray(testArray);
Print1DArr(testArray);