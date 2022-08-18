// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// нельзя использовать pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А и B, получите A в степени B и наоборот!");
Console.Write("Введите число А :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B :");
int b = Convert.ToInt32(Console.ReadLine());
int res1 = a;
//int res2 = b;

void Method1()
{
    for(int i = 1; i < b; i++)//"for" - ключеое слово, "int i = 1" - инициализация счетчика, "i < b" проверка условия, увеличение счетчика.
    {
        res1 = res1 * a;
    }
    Console.WriteLine("А в степени В равно:" + res1);
}
// void Method2()//немного поигрался и добавил метод наоборот
// {
//     for(int i = 1; i < a; i++)
//     {
//         res2 = res2 * b;
//     }
//     Console.WriteLine("а B в степени A равно:" + res2);
// }
Method1();
//Method2();


