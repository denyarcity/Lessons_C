// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


Console.Clear();
Console.WriteLine($"Задайте значения M и N, а программа выведет все натуральные числа в промежутке от M до N!");
int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");
Console.Write("Все натуральные числа: ");
PrintNumber(n, m);

void PrintNumber(int n, int m)
{
  if (m > n) return;
  PrintNumber(n, m + 1);
  Console.Write(m + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}