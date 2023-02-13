// Задача №5
// Напишите программу которая на вход принимает одно число N
// а на выходе показывает все целые числа в промежутке от от -N до N

Console.WriteLine("Введите число: ");
// Считываем данные с консоли 
string? inputLine = Console.ReadLine();
// Проверяем что бы данные были не пустыми
if(inputLine!=null)
{
    // Персим введенное число
    int inputNumber = int.Parse(inputLine);
    //Вводим переменную которая накапливает строку
    
    int startNumber = inputNumber*(-1);
    // Выходное значение
    string? outLine = string.Empty;
    while(startNumber<inputNumber)
    {
        outLine = outLine + startNumber + ", ";
        startNumber++;
    }
    outLine = outLine + inputNumber;
    // Выводим данные в консоль
    Console.WriteLine(outLine);    
}