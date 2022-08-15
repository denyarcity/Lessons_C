// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7 обозначающее день недели: ");
int num_day = Convert.ToInt32(Console.ReadLine());

void check_day (int num_day) 
{
  if (num_day == 6 || num_day == 7) 
  {
  Console.WriteLine("Это выходной день");
  }
  else if (num_day < 1 || num_day > 7) 
  {
    Console.WriteLine("Нет такого дня недели");
  }
  else 
  {
    Console.WriteLine("Это рабочий день");
  }
}

check_day(num_day);

//Поигрался с кодом и расписал каждый день недели подробно
// Console.Write("Введите число от 1 до 7 обозначающее день недели: ");
// int num_day = Convert.ToInt32(Console.ReadLine());

// void check_day (int num_day)
// {
//     if(num_day == 1)
//     {
//         Console.WriteLine("Это понедельник, рабочий день");
//     }
//     else if(num_day == 2)
//     {
//         Console.WriteLine("Это вторник, рабочий день");
//     }
//     else if(num_day == 3)
//     {
//         Console.WriteLine("Это среда, рабочий день");
//     }
//     else if(num_day == 4)
//     {
//         Console.WriteLine("Это четверг, рабочий день");
//     }
//     else if(num_day == 5)
//     {
//         Console.WriteLine("Это пятница, все еще рабочий день");
//     }
//     else if(num_day == 6)
//     {
//         Console.WriteLine("Это суббота, выходной день");
//     }
//     else if(num_day == 7)
//     {
//         Console.WriteLine("Это воскресенье, выходной день");
//     }
//     else
//     {
//         Console.WriteLine("Нет такого дня недели");
//     }
// }

// check_day(num_day);