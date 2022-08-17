﻿//Виды методов:

//=>1 - Методы которые ничего не принимают и ничего не возвращают:

void Method1()
{
    Console.WriteLine("Автор .....");
}
// Method1();
//Данный пример показывает возможность выведения текстовой инф-ии путем вызова метода "Method1()"
//Не нужно постоянно писать код для вывода однообразного текста, просто вызываешь метод и все.

//==>2 - Методы которые могут принимать аргументы, но ничего не возвращают.

void Method2(string msg) // void - ключевое слово, Method2 -идентификатор, и в скобочках аргументы.
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения"); //Именованные аргументы - указываем к какому аргументу какое значение мы хотим указать. Это нужно в случаях, когда методы принимают какое-то кол-во аргументов.
//Данный пример показывает возможность выведения текстовой инф-ии путем вызова метода "Method1()"

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count) //Цикл while в котором предусмотренно поворение текста i раз, но не более count раз, которое укажет пользователь.
    {
        Console.WriteLine(msg);
        i++; //Увеличение на единицу это "Инкримент", а уменьшение на единицу это "Дикримент".
    }
}
//Method21(msg: "ТЕКСТ", count: 4); //Лучше использовать именованные аргументы, таким образом можно их отображать в разном порядке.
//В данном примере рассмотрена возможность вывода текста необходимое кол-во раз.

//===>3 - Методы которые ничего не принимают, но что-то возвращают

int Method3() //В скобочках аргументов нет, т.к. он их не принимает.
{
    return DateTime.Now.Year;
}
int year = Method3();//присваиваем year данные полученные в методе
int back_year = year - 1; //ради интереса вычел один год из текущего.
//Console.WriteLine(back_year);//выводим их на экран.
//В данном примере рассмотрен вариант вывода текущего года

//====> 4 - Методы которые что-то принимают и что-то возвращают

// string Method4(int count, string text) //аргументы число и строка
// {
//     int i = 0;
//     string result = String.Empty; // присваиваем result пустую строку
//     while(i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result; //Оператор return завершает выполнение метода, в котором он присутствует, и возвращает управление и результат функции (при его наличии) вызывавшему методу.
// }
// string res = Method4(10, "asdf|");
//Console.WriteLine(res);
//Данный пример показывает вывод текста в строку друг за другом необходимое кол-во раз.

//=====> Цикл "for" вместо "while"

string Method4(int count, string text) //аргументы число и строка
{
    
    string result = String.Empty; // присваиваем result пустую строку
    for(int i = 0; i<count; i++) //"for" - ключеое слово, "int i = 0" - инициализация счетчика, "i<count" проверка условия, увеличение счетчика.
    {
        result = result + text;
    }
    return result; //Оператор return завершает выполнение метода, в котором он присутствует, и возвращает управление и результат функции (при его наличии) вызывавшему методу.
}
string res = Method4(10, "asdf|");
//Console.WriteLine(res);

//======> Цикл внутри цикла. Пример "Таблица умножения":

// for(int i = 2; i <= 10; i++) //пока счетчик i меньше 10, будем его увеличивать.
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");//интерпаляция строк
//     }
//     Console.WriteLine(); //Данная строка позволяет длать переход на новую строку после отработки каждого цикла
// }

//=======> Задача с текстом
// - все пробелы заменить черточками
// - маленькие "к" заменить на большие "К"
// - большие "С" заменить на маленькие "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// в стоке можно обратиться к конкретному символу строки [0],[1],[2],[...]
//4 вид методов.
string Replace(string text, char oldValue, char newValue) //"string text" - какой-то текст, "char oldValue" - старый символ, "char newValue" - новый символ.
{
    string result = String.Empty; //новая пустая строка String.Empty 

    int length = text.Length; //получаем длинну строки обратившись к text
    for (int i = 0; i < length; i++) //используя цикл for начинаем с символа с индексом 0 до конца строки i<length делая следующее действие:  
    {
        if (text[i] == oldValue) result = result + $"{newValue}";//если текущий символ text[i] совпал с символом, который мы хотим заменить oldValue то в результат result = result мы должны положить newValue
        else result = result + $"{text[i]}";//если совпадений не обнаружено, то нужно положить текущий символ, который там и был
    }

    return result; //возвращаем результат
}

// string newText = Replace(text, ' ', '_');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);

//========> Алгоритм сортировки методом выбора

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array) //метод для вывода массива на экран
{
    int count = array.Length;
    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) //метод для упорядочивания массива
{
    for(int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        
        for(int j = i+1; j < array.Length; j++)//цикл который ищет минимальный элемент
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        
        //данный блок кода меняет позиции
        int temporary = array[i]; //temporary присваиваем текущую позицию array[i]
        array[i] = array[minPosition]; //в array[i] присваиваем элемент найденный в результате работы второго цикла for (обмен двух переменных местами)
        array[minPosition] = temporary; 
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);