// Задача 31
// Задайте масив из 12 элементов, заполненый случайными числами
// в промежутке от -9 до 9, найдите сумму отрицательных 
// и положительных элементов масива.



 //Метод выводит данные пользователя
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}
//Метод который генерирует рандомные числа
int[] GenArr(int len, int min, int max)
{
    //Блок корректировки входных данных
    if(min>max)
    {
        int buf = min;
        min = max;
        min = buf;
    }
    Random rnd = new Random();
    int[] arr = new int[len]; 
    for (int i=0; i< arr.Length; i++)
    {
        arr[i] = rnd.Next(min,max+1);
    }
    return arr;
}

//Печатает одномерный массив
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i< arr.Length-1;i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
//Метод который считает положительные и отрицательные числа
(int posit, int negot) NegPosSum(int[] arr)
{
    int positSum = 0;
    int negotSum = 0;
    for (int i=0; i< arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            positSum += arr[i];
        }
        else
        {
            negotSum+=arr[i];
        }
    }
    return (positSum, negotSum);
}

int[] testArr = GenArr(12,-9,9);
PrintArr(testArr);
(int posit,int negot) results = NegPosSum(testArr);
PrintData("Сумма положительных чисел в массиве: ",results.posit);
PrintData("Сумма отрицательных чисел в массиве: ",results.negot);