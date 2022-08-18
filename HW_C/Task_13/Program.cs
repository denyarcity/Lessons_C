// Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран.
// пример вывода
// [1,4,5,3,1,2,3,9]
// [4,45,53,31,14,25,63,19]

Console.Write("Укажите из какого кол-ва элементов должен состоять массив?: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите из какого диапазона случайных чисел от 0 до N будут генерироваться числа? Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[i]; //просим программу создать массив из "i" элементов

void FillArray (int[] collection)//метод который присваивает к каждому индексу в массиве случайное число.
{
    int length = collection.Length; //получаем длинну массива
    int index = 0;
    while (index < length)// пока index меньше length производим слеующее действие:
    {
        collection[index] = new Random() .Next(0,n);//collection[index] - обращаемся к индексу в аргументе и присваиваем ему новое случайное число в промежутке от 1 до "n" 
        index++;// index = index + 1
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;//кол-во элементов
    int position = 0;//позиция
    while (position < count)// пока position меньше count, мы будем выводить на экран консоль со значением текущего элемента
    {
        Console.Write(" " + col[position] + ",");
        position++;
    }
}

FillArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");