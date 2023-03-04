// Задача № 48
// Задайте двухмерный массив, размером m на n, каждый 
// элемент в масиве находится по формуле А(n,m)=m+n
// выведети полученный масив на экран

 //Метод заполения двухмерного массива по формуле А(n,m)=m+n
 int [,]Gen2DArrMod(int row, int col)
 {
    int[,] resArr = new int[row,col];
    for(int i=0; i<row; i++)
    {
        for(int j=0;j<col; j++)
        {
            resArr[i,j] = i+j;
        }
    }
    return resArr;
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

int[,] array = Gen2DArrMod(8,8);
Console.WriteLine("Исходный масив: ");
Print2DArr(array);
