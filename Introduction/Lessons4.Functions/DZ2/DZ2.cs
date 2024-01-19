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
       // int even_nambers = 0;
// пока в массиве есть место, то добавляем в него произвольные числа от 100 до 950
    // static void random_number(int[] random_numbers)  
            for (; i< number.Length ; i++)
                    {   
                        Random random = new Random();
                         number[i]= random.Next (100, 950);
                    }
           
            

//Передача массива в функцию EvenNumber
        EvenNumber(number);

// Подсчит количества четных чисел 
        static void EvenNumber (int[] number)
        {   
            int even_nambers=0;     
            for (int k=0; number.Length > k ; k++) 
                {
                     if (number[k] % 2 == 0)
                            {
                                even_nambers = even_nambers +1;
                    
                            }
                }                      
//вывод в консоль количества четных чисел в массиве.
            Console.WriteLine($"Количество четных чисел: {even_nambers}");
        }
 // Передаем массив в функцию вывода произвольных чисел которые в массиве.
                PrintNumber(number);
// Функция вывода произвольных чисел 
                static void PrintNumber(int[] numbers)
                    {
                        Console.Write($"Все случайно сгенерированные числа: \t");
                            for (int j=0; numbers.Length > j ; j++)
                                {
                                    Console.Write($"{numbers[j]}\t");
                                }
                    }
    }
}

