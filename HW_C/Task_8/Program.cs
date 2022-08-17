﻿// Напишите метод, который принимает на вход шестизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// строки использовать нельзя
//Примечание: палиндромом называется число, слово или текст, которые одинакового читаются слева направо и справа налево.

Console.Write("Введите шестизначное число и узнайте является ли оно палиндромом: ");
int num = Convert.ToInt32(Console.ReadLine());

void Method()
{
    if (num < 100000 || num > 999999)
    {
        Console.WriteLine("Вы ввели не корректное число!");
    }
    else
    {
        int num6 = (num % 10);
        int num5 = (num % 100) / 10;
        int num4 = (num % 1000) / 100;
        int num3 = (num % 10000) / 1000;
        int num2 = (num % 100000) / 10000;
        int num1 = (num / 100000);
    
        if(num1 == num6 && num2 == num5 && num3 == num4)
        {
            Console.WriteLine("Это число является полиндромом");
        }
        else
        {
            Console.WriteLine("Это число не является полиндромом");
        }
    }
}

Method();