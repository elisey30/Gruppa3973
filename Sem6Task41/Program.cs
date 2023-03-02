// Задача № 41
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// *Пользователь вводит число нажатий, затем программа следит
//  за нажатиями и выдает сколько чисел больше 0 было введено.

//Метод ввода данных 
int ReadDate(string msg) 
{ 
    Console.WriteLine(msg); 
    return int.Parse(Console.ReadLine() ?? "0"); 
} 
// метод печати 
void PrintData(string msg, int num) 
{ 
    Console.WriteLine(msg + num); 
} 
// метод нахождения чисел больше 0 
int CountNum(int numM) 
{ 
    int res = 0; 
    for (int i = 0; i < numM; i++) 
    { 
        if(ReadDate("Введите число: ")>0) 
        { 
            res++; 
        } 
    } 
    return res; 
} 

int newnum = ReadDate("Введите M чисел: "); 
int count = CountNum(newnum); 
PrintData("колличество чисел больше нуля: ", count);