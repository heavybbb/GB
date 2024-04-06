/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/
using System;

class Program
{
    static void Main()
    {


        string inputString = " ";
        string[] inputStringArray = new string[100];
        for (int i = 0; inputStringArray.Length >= i && inputString != ""; i++)

        {
            Console.WriteLine("Введите строку, по завершении ввода нажмите Enter ничего не вводя");
            inputString = Console.ReadLine();
            inputStringArray[i] = inputString;
        }

            string[] newArray = new string[100];
            int count = 0;
            foreach (string item in inputStringArray)
            {
                if (item.Length <= 3)
                {
                    newArray[count] = item;
                    Console.WriteLine(newArray[count]);
                    count++;
                
                }

            }
    }
}


    
