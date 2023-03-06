// Задача № 50
// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// *Заполнить числами Фиббоначи и выделить цветом найденную цифру

// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Метод образования двухмерного масива с рондомными числами
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}
//Метод поиска числа массива по запросу столбца и стоки
void FindNumber(int[,] arr, int row, int column)
{
    if (row < arr.GetLength(0) && column < arr.GetLength(1))
    {
        int num = arr[row, column];
        Console.WriteLine("Найденое число по заданным координатом: " +num);
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет: ");
    }
}
//Метод печати 2 d массива
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]+ "\t");
        }
        Console.WriteLine();
    }    
}

int row = ReadData("Введите позицию в строке: ");
int column = ReadData("Введите позицию в столбце: ");
int[,] arr2D = Gen2DArr(10,10, 1, 10);
Print2DArr(arr2D);
FindNumber(arr2D,row,column);
