// Задача № 55
// Задайте двухмерныймассив, напишите программу которая заменит
// строки на солбцы в случае если это невозможно, программа
// должна вывести сообщение для пользователя, что это сделать невозможно.

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
    Console.WriteLine();
}
//Метод который заменяет строки на столбцы
void TranspArr(int[,] arr)
{
    int temp = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = i+1; j<arr.GetLength(1); j++)
        {
            temp = arr[i,j];
            arr[i,j] = arr[j,i];
            arr[j,i] = temp;
        }
    }
}

int row = ReadData("Введите колличество строк: ");
int column = ReadData("Введите колличество столбцов: ");
Console.WriteLine();

int[,] testArr = Gen2DArr(row, column, 10, 99);
Print2DArr(testArr);
if(testArr.GetLength(0) == testArr.GetLength(1))
{
    TranspArr(testArr);
    Print2DArr(testArr);
}
else
{
    Console.WriteLine("Это сделать невозможно т к матрица не квадратная: ");
}
Console.WriteLine();