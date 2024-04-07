// /*
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// */
    
using System;
class Program
{
    static void Main()
    {
        string[] inputStringArray = new string[100];
        int count = 0;

        Console.WriteLine("Введите строки. Для завершения ввода нажмите Enter без ввода текста.");

        // Ввод строк до тех пор, пока пользователь не нажмет Enter без ввода текста
        string inputString;
        do
        {
            inputString = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputString))
            {
                inputStringArray[count] = inputString;
                count++;
            }
        } 
        while (!string.IsNullOrEmpty(inputString) && count < 100);

        // Создание нового массива из строк, длина которых меньше или равна 3 символам
        string[] newArray = new string[count]; // Создаем массив нужного размера
        int newArrayIndex = 0;
        for (int i = 0; i < count; i++)
        {
            if (inputStringArray[i].Length <= 3)
            {
                newArray[newArrayIndex] = inputStringArray[i];
                newArrayIndex++;
            }
        }

        // Вывод нового массива
        Console.WriteLine("Строки с длиной <= 3 символов:");
        for (int i = 0; i < newArrayIndex; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}