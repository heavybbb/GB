/* Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы. */

using System;
class Program
{
    static void Main()
    {

        Console.Write("Введите первое число: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        AllNumbersFromOneToTen(firstNumber, secondNumber);
    }
    static void AllNumbersFromOneToTen(int firstNumber, int secondNumber)

    {
        if (firstNumber == secondNumber)
        {
            return;
        }
        if (firstNumber < secondNumber)
        {
            ++firstNumber;
            Console.Write(firstNumber + " ");
        }
        if (firstNumber > secondNumber)
        {
            firstNumber--;
            Console.Write(firstNumber + " ");
        }
        AllNumbersFromOneToTen(firstNumber, secondNumber);
    }

}

