// Задача № 40
// Напишите программу которая принимает на вход 3 числа
// и проверяет может ли существовать треугольник со сторонами 
// такой длины


// Метод считываем данные с пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ??"0");
}
//Метод вывода результата
void PrintData(string msg, bool num)
{
    Console.WriteLine(msg+num);
} bool Test (int a, int b, int c)
    {
    return(a<=b+c);
    }
//Метод который проверяет может ли существовать треугольник со сторонами 
// такой длины
bool TriangleTest(int a,int b, int c)
{
    bool res = false;
    if(Test(a,b,c)&& Test(b,a,c)&& Test(c,a,b))
    {
        res = true;
    }
    return res;
}

int sideA = ReadData("Напишите длину отрезва А");
int sideB = ReadData("Напишите длину отрезва В");
int sideC = ReadData("Напишите длину отрезва С");
PrintData("треугольник: ", TriangleTest(sideA,sideB,sideC));