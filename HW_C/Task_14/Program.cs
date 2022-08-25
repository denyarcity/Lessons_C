// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Укажите из какого кол-ва трехзначных чисел должен состоять массив: ");
int mas = Convert.ToInt32(Console.ReadLine());

void FillArray (int[] collection){
    for(int i=0; i<collection.Length; i++){
        collection[i] = new Random().Next(100,1000);
    }
}

void PrintArray (int[] col){
    for(int i=0; i<col.Length; i++){
        Console.Write(col[i] +" ");
    }
    Console.WriteLine();
}

int[] array = new int[mas];
int count = 0;
FillArray (array);
Console.Write("Mассив заполненный случайными положительными трёхзначными числами: ");
PrintArray (array);

for (int i=0; i<array.Length; i++){
    if (array[i]%2 == 0){
        count++;
    }
}
Console.WriteLine("Kоличество чётных чисел в массиве: " + count);