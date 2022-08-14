//программа создаст массив из 10 элементов. Если мы не задем числа, то они по умолчанию будут "0". 
int[] array = new int[10];

void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random() .Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
           position = index;
           break;
        }
        index++;
    }
    return position;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

//Данная программа позволяет создавать массив из десяти рандомных чисел и выводить их на экран. + находит индекс первого искомого числа в конце.


