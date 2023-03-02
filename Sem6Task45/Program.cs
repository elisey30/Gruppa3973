// Задача No45 
// Напишите программу, которая будет создавать копию заданного одномерного 
// массива с помощью поэлементного копирования. 
 
// Метод генерации массива 
int[] Gen1DArr(int len, int minValue, int maxValue) 
{ 
    // Блок корректировкивходных данных 
    if (minValue > maxValue) 
    { 
        int buf = minValue; 
        minValue = maxValue; 
        maxValue = buf; 
    } 
 
    Random rnd = new Random(); 
    int[] arr = new int[len]; 
 
    for (int i = 0; i < arr.Length; i++) 
    { 
        arr[i] = rnd.Next(minValue, maxValue); 
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
//Метод копирования массива 
int[] CopyArrayStandartTools(int[] inputArr) 
{ 
    int[] outArr = new int[inputArr.Length]; 
    inputArr.CopyTo(outArr,0); 
    return outArr; 
} 
 
//Метод копирования массива универсальный 
// object[] CopyArrayStandartTools(params object[] inputArr) 
// { 
//     object[] outArr = new object[inputArr.Length]; 
//     inputArr.CopyTo(outArr,0); 
//     return outArr; 
// } 
int[] testArr =Gen1DArr(40,1,50); 
Print1DArr(testArr); 
int[] testArrnew = CopyArrayStandartTools(testArr); 
Print1DArr(testArrnew);