// Задача № 62
// Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Введите количество элементов в строке"); 
int n = int.Parse(Console.ReadLine()?? "0"); 
Console.WriteLine("Введите количество элементов в cтолбце"); 
int m = int.Parse(Console.ReadLine()?? "0"); 
int[,] mas = new int[m, n]; 
int k = 1; 
int t = 0; 
int i, j = 0; 
int n1 = n; 
int m1 = m; 
 
    while (k <= n1 * m1) 
    { 
        for (i = t; i < n; i++) 
            mas[j, i] = k++; 
            j = n - 1; 
        for (i = t + 1; i < m; i++) 
            mas[i, j] = k++; 
            j = m - 1;  
        for (i = n - 2; i >= t; i--) 
            mas[j, i] = k++; 
            j = t; 
        for (i = m - 2; i > t; i--) 
            mas[i, j] = k++; 
            n--; 
            m--; 
            t++; 
            j = t; 
    } 
for (i = 0; i < mas.GetLength(0); i++) 
    { 
        for (j = 0; j < mas.GetLength(1); j++) 
            Console.Write("{0,2} ", mas[i, j]); 
            Console.WriteLine(); 
    } 
 
