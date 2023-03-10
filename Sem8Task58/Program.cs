// Задача № 58
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//Метод создания двух матриц с рондомными числами
void CreateTooArray(int[,] matr1, int[,] matr2)
{
    for (int m = 0; m < matr1.GetLength(0); m++)
    {
        for (int n = 0; n < matr1.GetLength(1); n++)
        {
            matr1[m, n] = new Random().Next(1, 10);
        }
    }
    for (int m = 0; m < matr2.GetLength(0); m++)
    {
        for (int n = 0; n < matr2.GetLength(1); n++)
        {
            matr2[m, n] = new Random().Next(1, 10);
        }
    }
}
//Метод печати 2 d массива двух матриц
void Print2DArr(int[,] matr1, int[,] matr2)
{
    for (int m = 0; m < matr1.GetLength(0); m++)
    {
        for (int n = 0; n < matr1.GetLength(1); n++)
        {
            Console.Write($"{matr1[m, n]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int m = 0; m < matr2.GetLength(0); m++)
    {
        for (int n = 0; n < matr2.GetLength(1); n++)
        {
            Console.Write($"{matr2[m, n]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Результирующая матрица будет ровна: ");
}
//Метод нахождения произведение двух матриц
void Sum2Matric(int[,] matr1, int[,] matr2, int[,] sumMatr)
{
    for (int m = 0; m < matr1.GetLength(0); m++)
    {
        for (int n = 0; n < matr1.GetLength(1); n++)
        {
            sumMatr[m, n] = matr1[m, n] * matr2[m, n];
        }
    }
}
//Метод который печатает произведение двух матриц
void PrintSumArr(int[,] sumMatr)
{
    for (int m = 0; m < sumMatr.GetLength(0); m++)
    {
        for (int n = 0; n < sumMatr.GetLength(1); n++)
        {
            Console.Write($"{sumMatr[m, n]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] sumMatr = new int[2, 2];
CreateTooArray(matrix1, matrix2);
Print2DArr(matrix1, matrix2);
Console.WriteLine();
Sum2Matric(matrix1, matrix2, sumMatr);
PrintSumArr(sumMatr);