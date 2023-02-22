// Задача 24
// Напмшите программу которая принимает на вход число(А)
// и выдает сумму числел от одного до А

// Запрос данных у пользователя 
int ReadData(string msg)
{
    // Выводим сообщение
    Console.WriteLine(msg);
    // Считываем число и возвращаем значение
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}
// Метод вывода результата
void PrintResult(string msg)

{
    Console.WriteLine(msg);
}
//Cоздаем метод который суммирует от 1 до А
int SumSimple(int numA)
{
    int sum = 0;
    for(int i=0; i<=numA;i++)
    {
        sum+=i;
        //sum=sum+1
    }
    return sum;
}

int numberA = ReadData("Ввидите число А: ");
//Замеряем скорость выполнения программы
DateTime d1 = DateTime.Now;
int res1 = SumSimple(numberA);
//Выводим скорость выполнения программы
Console.WriteLine(DateTime.Now - d1);

PrintResult("Сумма чисел от 1 да А: "+ res1);