// Напишите программу которая принимает на вход число N
// и выдает таблицу квадратов чисел от 1 до N

// Метод считывает данные от пользователя
int ReadInput(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine()?? "0");
}
// Метод выводит данные пользователя
string LineBuilder(int end, int pow)
{
    string res = String.Empty;
    for(int i = 1; i<=end; i++)
    {
        res = res + Math.Pow(i,pow)+"\t";
    }
    return res;
}
int N = ReadInput("введите число: ");
Console.WriteLine(LineBuilder(N,1));
Console.WriteLine(LineBuilder(N,2));