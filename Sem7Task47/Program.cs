// // Задача № 47
// // Задайте двумерный массив размером m×n, 
// // заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// *При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)


//Метод ввода данных 
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Метод генерации вещественных рандомных чисел в двухмерном массиве с корректировкой входных данных
double[,] Gen2DArr(int row, int column, int min, int max)
{
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    double[,] array = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = rnd.Next(min, max) + rnd.NextDouble();
        }
    }
    return array;
}
//Метод вывода двухмерного масива
void Print2DArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]+ " ");
        }
    }
        Console.WriteLine();
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
double[,] arr2D = Gen2DArr(row, column,5,10);
Print2DArr(arr2D);