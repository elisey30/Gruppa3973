// Задача №30
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// Метод считываем данные с пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()?? "0");
}
// Метод который генерирует рандомные числа
int[] GenArr(int num, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i=0; i< arr.Length; i++)
    {
        arr[i] = rnd.Next(min,max+1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i< arr.Length-1;i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
//Обращение к методу ReadData 
int len = ReadData("Введите длинну массива: ");
int min = ReadData("Введите минимальное число в массиве: ");
int max = ReadData("Введите максимальное число в массиве: ");
//Обращение к метду GenArr 
int[] mas = GenArr(len,min,max);
//Обращение к методу PrintArr
PrintArr(mas);
