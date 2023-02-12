// Задача 3
// Напишите программу, которая будет выдавать названия дня недели по задоному числу!

Console.WriteLine("Введите число: ");
// Считываем данные с консоли 
string? lineDay = Console.ReadLine();
// Проверяем что бы данные были не пустыми
if (lineDay != null)
{
    // Персим введенное число
    int day = int.Parse(lineDay);
    // Создаем масив
    string[] dayWeek = new string[7];
    dayWeek[0] = "Понедельник";
    dayWeek[1] = "Вторник";
    dayWeek[2] = "Среда";
    dayWeek[3] = "Четверг";
    dayWeek[4] = "Пятница";
    dayWeek[5] = "Суббота";
    dayWeek[6] = "Воскресенье";
    Console.WriteLine(dayWeek[day-1]);
}