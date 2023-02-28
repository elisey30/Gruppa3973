// Задача №37
// Найдите произведение пар чисел в одномерном массиве,
// парой считаются первый и последний элемент, второй и предпоследний и т.д.
// результат запишите в новый массив


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
//Метод который умножает первую и последнюю, второй и предпоследний и т д пару чисел в масиве
int[] ConvertArr(int[] arr)
{
    int[] butArr = new int[(arr.Length/2)+1];
    for(int i = 0; i <((arr.Length/2)+1);i++)
    {
        butArr[i] = arr[i]*arr[arr.Length -1 - i];
    }
    return butArr;
}

int[] msg = Gen1DArr(6,1,9);
Print1DArr(msg);
int [] newArr = ConvertArr(msg);
Print1DArr(newArr);
