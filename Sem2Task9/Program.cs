// Задача № 9
// Напишите программу которая выводит случайное число из отрезка от 10
// до 99 и показывает наибольшую цыфру числа.


// Рандомный синтезатор чисел,где new выделяет память под обьект

System.Random numSintezator = new System.Random();

// Задаем переменную, обращаемся к синтезатору чисел и просим его 
// предоставить числа от 10 до 100

int rndNumber = numSintezator.Next(10,100);

// Посмотрим на синтезирование числа
Console.WriteLine(rndNumber);

// Задаем две переменных и кладем туда рандомные числа

int firstNum = rndNumber/10;
int secondNum = rndNumber%10;

// Спрашиваем какое число больше

if(firstNum>secondNum)
{
    //Выводим данные на консоль
Console.WriteLine("Первое число " +firstNum+ " Больше второго " +secondNum);
}
else
{
Console.WriteLine("Второе число  " +secondNum+ " Больше первого "+firstNum);
}