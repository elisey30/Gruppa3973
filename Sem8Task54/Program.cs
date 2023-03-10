// Задача № 54
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
//Метод сортировки масива
int[,] Sort2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int min = j;                                            
            for (int k = j + 1; k < array.GetLength(1); k++)                
            {
                if (array[i, k] > array[i, min]) min = k;    
            }
            int tmp = array[i, j];                                          
            array[i, j] = array[i, min];                            
            array[i, min] = tmp;                                    
        }

    }
    return array;
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


int[,] test = Gen2DArr(5, 5, 10, 99);
Print2DArr(test);

Console.WriteLine();
int[,] sortRow = Sort2DArray(test);
Print2DArr(sortRow);