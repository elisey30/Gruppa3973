// Задача № 59
// Задайте двухмерный массив из целых чисел и напишите 
// программу которая удалит строчку и столбец на пересечении 
// которой расположен наименьший элемент массива.

// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Метод печати 2 d массива
void Print2DArr(int[,] metr)
{
    for (int i = 0; i < metr.GetLength(0); i++)
    {
        for (int j = 0; j < metr.GetLength(1); j++)
        {
            Console.Write(metr[i, j]+ "\t");
        }
        Console.WriteLine();
    }    
    
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

(int x, int y) SearchMinElement(int[,] mstrix)
{
    int row = 0;
    int column = 0;
    int min = int.MaxValue;
    for(int i = 0; i < mstrix.GetLength(0); i++)
    {
        for(int j = 0; j < mstrix.GetLength(1); j++)
        {
            if(mstrix[i,j] < min)
            {
                min = mstrix[i,j];
                row = i;
                column = j;
            }
        }
    }
    return (row, column);
}

int[,] Convertted2DArray(int[,] arr, int x, int y)
{
    int[,] outArr = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    int k = 0; int m = 0;
    for( int i = 0; i < arr.GetLength(0); i++)
    {
        m=0;
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(i != x && j != y)
            {
                outArr[k, m] = arr[i,j];
            }
            if(j != y) m++;
        }
        if (i != x) k++;
    }
    return outArr;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArr(row, column, 0, 99);
Print2DArr(arr2D);
Console.WriteLine();
(int x, int y) minElem = SearchMinElement(arr2D);
int[,] out2DArr = Convertted2DArray(arr2D,minElem.x, minElem.y);
Print2DArr(out2DArr);