// Задача №17
// Напишите программу которая принимает на вход координаты точки х,у,
// причем х,у не равны 0. И выдает номер четверти плоскости в которой
// находится эта точка.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод определяет четверть по координатам точки
void PrintQuterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка в 1 четвери");
    if (x > 0 && y < 0) Console.WriteLine("Точка в 2 четвери");
    if (x < 0 && y < 0) Console.WriteLine("Точка в 3 четвери");
    if (x < 0 && y > 0) Console.WriteLine("Точка в 4 четвери");
}

int coordX = ReadData("Введите координату Х:");
int coordY = ReadData("Введите координату Y:");
PrintQuterTest(coordX,coordY);