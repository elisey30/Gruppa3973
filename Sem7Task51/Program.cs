// Задача № 51
// Задайте двухмерный массив , найдите сумму элементов находящихся 
// на главном диапозене с индесами 0,1 и т.д.


//Метод ввода данных 
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Метод вывода результата
void PrintData(string msg, int num)
{
    Console.WriteLine(msg+num);
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
// Метод котрый считает сумму элементов находящимся на главном диапозене
int CountMainDiay (int[,]arr)
{
    int res = 0;
    int min = arr.GetLength(0) > arr.GetLength(1)? arr.GetLength(1): arr.GetLength(0);
    for(int j = 0; j < min; j++)
    {
        res = res+arr[j,j];
    }
    return res;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArr(row, column, 8, 9);

Print2DArr(arr2D);
PrintData("Сумма диоганальных элементов: ", CountMainDiay(arr2D));

