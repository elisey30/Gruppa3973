// // Задача No44 
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. 
 
//Метод ввода данных 
int ReadDate(string msg) 
{ 
    Console.WriteLine(msg); 
    return int.Parse(Console.ReadLine() ?? "0"); 
} 
// метод ввывода печати 
void PrintResult(string msg, string num) 
{ 
    Console.WriteLine(msg + num); 
} 
// Метод вывода чисел фибоначи 
string FibNum(int num) 
{ 
    string res ="0 1"; 
    int first =0; 
    int last = 1; 
    for (int i = 2; i < num; i++) 
    { 
        res =res+" "+(first+last).ToString(); 
        (first,last)=(last,first+last); 
    } 
    return res; 
} 

int test = ReadDate("Ведите количество цифр в числе фебоначи"); 
PrintResult("число Фибоначи: " , FibNum(test));
