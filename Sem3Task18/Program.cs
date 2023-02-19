// Задача № 18
// Напишите программу которая по заданному номеру четвертти показывает
// диапозон возможных координат точки этой четверти. 

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод определяет координаты точки по номеру четверти
void PrintAnsor(int num)
{
    if (num > 0 && num< 5)
    {
    if (num == 1) Console.WriteLine("x > 0, y > 0");
    if (num == 2) Console.WriteLine("x > 0, y < 0");
    if (num == 3) Console.WriteLine("x < 0, y < 0");
    if (num == 4) Console.WriteLine("x < 0, y > 0");
    }
    else
    {
        Console.WriteLine("Неверная четверть: ");
    }
}

int quarter = ReadData("Введите номер четверти:");
PrintAnsor (quarter);
