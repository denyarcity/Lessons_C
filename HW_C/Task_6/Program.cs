// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num_text = Convert.ToString(num);
if (num_text.Length > 2)
{
  Console.WriteLine("Третья цифра = " + num_text[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}



// string str = "abcdefg";
// Console.WriteLine("1) The length of '{0}' is {1}", str, str.Length);
// Console.WriteLine("2) The length of '{0}' is {1}", "xyz", "xyz".Length);

// int length = str.Length;
// Console.WriteLine("3) The length of '{0}' is {1}", str, length);