// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Укажите из какого кол-ва чисел должен состоять массив: ");
int mas =Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите диапазон от: ");
int range1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите диапазон до: ");
int range2 =Convert.ToInt32(Console.ReadLine());

double[] arrayRealNumbers = new double[mas];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(range1, range2);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\n максимальное число - |{maxNumber}|, минимальное число - |{minNumber}|, разница между ними: |{decision}|");
