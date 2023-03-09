// Задача № 53
// Задайте двухмерный массив и напишите программу 
// которая поменяет местами первую и последнюю строчку массива.

// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Метод образования двухмерного масива с рондомными числами
void Gen2DArr(int[,] matr, int min, int max)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    
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
// Метод который меняет местами первую и последнюю строчку
 void Chahge2DArray(int[,]matr)
 {
    int temp = 0;
    for(int i = 0; i<matr.GetLength(1); i++)
    {
        temp=matr[0,i];
        matr[0,i]=matr[matr.GetLength(0)-1,i];
        matr[matr.GetLength(0)-1,i]= temp;
    }
 }

int m = ReadData("Введите колличество строк: ");
int n = ReadData("Введите колличество столбцов: ");
int[,] matrix = new int[m,m];
Gen2DArr(matrix,1,100);
Print2DArr(matrix);
Chahge2DArray(matrix);
Print2DArr(matrix); 