﻿// Задача № 20
// Напишите программу которая принимает на вход координаты двух
// точек и находит растояние между этими двумя точками. В 2D пространстве.

// Метод считывает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод выводит данные пользователя
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}
// Метод находит растояние между точками на плоскости
double CalcLen2D(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}
int x1 = ReadData("Введите координату х точки А: ");
int y1 = ReadData("Введите координату y точки А: ");
int x2 = ReadData("Введите координату х точки B: ");
int y2 = ReadData("Введите координату y точки B: ");

double res = CalcLen2D(x1,x2,y1,y2);
PrintData("Расстояние между точками А и В: ", res);