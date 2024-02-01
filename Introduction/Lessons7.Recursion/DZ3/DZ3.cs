/* Задача 3: Задайте произвольный массив. 
Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы. */

using System;

class Program
{
    static void Main()
    {
        int[] array = { 11, 21, 31, 42, 55 };
        PrintArrayReverse(array, array.Length - 1);

        Console.ReadLine(); 
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0)
            return;

        Console.Write(array[index] + " ");
        PrintArrayReverse(array, index - 1);
    }
}