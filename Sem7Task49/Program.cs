// Задача № 49
// Задайте дыухмерный масив, найдите элементы у которых 
// оба индекса четные и замените эти элементы на их квадраты.


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
//Метод раскрашинания рондомных чисел в консоле
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0,16)];
            Console.Write(arr[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
// Метод котрый ищет элементы у которых 
// оба индекса четные и меняет эти элементы на их квадраты.
void Update2Darr(int[,]arr)
{
    for(int i = 0; i < arr.GetLength(0); i+=2)
    {
        for(int j = 0; j < arr.GetLength(1); j+=2)
        {
            arr[i,j]*=arr[i,j];
        }
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArr(row, column, 8, 9);
Update2Darr(arr2D);
Print2DArr(arr2D);

