// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        int [] number = new int[10] ;
        int i=0;
// пока в массиве есть место, то добавляем в него произвольные числа от 100 до 950
    // static void random_number(int[] random_numbers)  
        
            for (; i< number.Length ; i++)
                    {   
                        Random random = new Random();
                         number[i]= random.Next (100, 950);
                    }
            i=0;
            int even_namber = 0;

// Подсчитываем количества четных чисел         
            for (; number.Length > i ; i++) 
                {
                     if (number[i] % 2 == 0)
                            {
                                 even_namber = even_namber +1;
                    
                            }
                        }
                         
//вывод в консоль количества четных чисел в массиве.
                Console.WriteLine(even_namber);

 // Передаем в функцию массив.
                PrintNumber(number);

// Функция печати массива 
                static void PrintNumber(int[] numbers)
                    {
                        for (int j=0; numbers.Length > j ; j++)
                                {
                                    Console.WriteLine(numbers[j]);
                    }

        }
    }
}

