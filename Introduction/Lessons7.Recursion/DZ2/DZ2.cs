/* Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = AckermannFunction(m, n);
        Console.WriteLine($"Результат: {result}");
    }
    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}