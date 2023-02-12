// Задача №0
// Напишите программу, которая на вход принимает число и выдает его квадрат 
//(число умноженное на само себя)

Console.WriteLine("Введите число: ");
// Считываем данные с консоли
string? inputNum = Console.ReadLine();

// Проверяем, что бы данные были не пустыми
if (inputNum != null)
{
    // Парсим введенное число
    int number = int.Parse(inputNum);
    // Находим квадрат числа 
    int outNum = number*number;

    // Выводим данные в консоль
    Console.WriteLine("Квадрат числа: "+outNum);
}
