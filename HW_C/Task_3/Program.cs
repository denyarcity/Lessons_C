//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 1)
    {
        Console.WriteLine(num + " - это нечетное число!");
    }
    else
    {
        Console.WriteLine(num + " - это четное число!");
    }