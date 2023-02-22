// Задача №26
//  Напишите программу, которая принимает на вход число
//  и выдаёт количество цифр в числе.

// Запрос данных у пользователя 
Console.WriteLine("Напишите число: ");
int num = int.Parse(Console.ReadLine()??"0");
 int count = 0;
while(num>0)
    {
        count+=1;
        num/=10;
    }
    
Console.WriteLine("Колличество цифр: " +count);
