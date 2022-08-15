// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result_2 = (num % 100) / 10;
Console.WriteLine("Второе число = "+ result_2);



// Немного поигрался и сделал программу проверяющую корректность ввода числа и вывод всех трех чисел по отдельности:
// Console.WriteLine("Введите целое трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 100 | num > 999)
//     {
//         Console.WriteLine("Вы вели не трехзначное число, попробуйте еще раз!");
//     }
// else
//     {
//         int result_1 = (num / 10) / 10;
//         int result_2 = (num % 100) / 10;
//         int result_3 = (num % 10);

//         Console.WriteLine("Первое число = "+ result_1);
//         Console.WriteLine("Второе число = "+ result_2);
//         Console.WriteLine("Третье число = "+ result_3);
//     }
        