// Задача № 57
// Составить частотный словарь элементов двухмерного массива,
// частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных

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
// Метод печати масива 
void Print1DArr(int[] arr) 
{ 
    Console.Write("["); 
 
    for (int i = 0; i < arr.Length - 1; i++) 
    { 
        Console.Write(arr[i] + ", "); 
    } 
    Console.WriteLine(arr[arr.Length - 1] + "]"); 
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

int[] FredDicBuild(int[,] arr, int len)
{
    int[] dic = new int[len];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            dic[arr[i,j]]++;
        }
    }
    return dic;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] testArr = Gen2DArr(row, column, 1, 9);
Print2DArr(testArr);
Console.WriteLine();

int[] freqDic = FredDicBuild(testArr, 10);
Print1DArr(freqDic);
