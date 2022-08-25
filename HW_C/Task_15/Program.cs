// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Укажите из какого кол-ва чисел должен состоять массив: ");
int mas =Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите диапазон от: ");
int range1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите диапазон до: ");
int range2 =Convert.ToInt32(Console.ReadLine());

int[] Arr = new int [mas];
int sum = 0;

Random rand = new Random();
for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rand.Next(range1, range2);
    
}

for (int i = 1; i < Arr.Length; i+=2)
{
        sum = sum + Arr [i];
    }

Console.WriteLine(string.Join(", ", Arr));
Console.WriteLine($"Cумма элементов на нечетных позициях = {sum}");