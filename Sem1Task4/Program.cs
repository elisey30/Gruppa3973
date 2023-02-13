// Задача 4: 
// Напишите программу, которая принимает на вход три числа и выдаёт
//  максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// ввод числа 1
Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
//ввод числа 2
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
//ввщд числа 3
Console.WriteLine("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

{

    if (num1 > num2)
    {
        if (num1 > num3)

        {
            Console.WriteLine("Большим число является: " + num1);
        }
        else
        {
            Console.WriteLine("Большим числом является: " + num3);
        }
    }
    else

    {
        if (num2 > num3)
        {
            Console.WriteLine("Большим числом является: " + num2);
        }
        else
        {
            Console.WriteLine("Большим числом является: " + num3);
        }


    }


}