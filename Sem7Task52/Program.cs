// // Задача № 52 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



//Метод ввода данных 
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
// Метод печати 1D массива 
void Print1DArr(double[] arr) 
{ 
    Console.Write("["); 
 
    for (int i = 0; i < arr.Length - 1; i++) 
    { 
        Console.Write(arr[i] + "\t "); 
    } 
    Console.WriteLine(arr[arr.Length - 1] + "]"); 
}
// Метод котрый считает среднеарифмитическое в каждом столбце
double[] ColMean2DArr (int[,]arr)
{
    double[] resArr = new double[arr.GetLength(1)];
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            resArr[j]+= arr[i,j];
        }
        resArr[j] = resArr[j] / arr.GetLength(0);
    }
    return resArr;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArr(row, column, 1, 10);
Print2DArr(arr2D);
double[] resCol = ColMean2DArr(arr2D);
Print1DArr(resCol);
