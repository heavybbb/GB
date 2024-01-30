/* 3: Задайте произвольную строку. 
Выясните, является ли она палиндромом.
using System;
using System.Globalization; */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку для проверки на палиндром:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("Это палиндром!");
        }
        else
        {
            Console.WriteLine("Это не палиндром.");
        }
    }

    static bool IsPalindrome(string str)
    {
        // Удаляем пробелы из строки
        string cleanedStr = str.Replace(" ", string.Empty);

        // Преобразуем строку в массив символов
        char[] charArray = cleanedStr.ToCharArray();

        // Инвертируем массив
        Array.Reverse(charArray);

        // Сравниваем исходную строку с инвертированной
        return cleanedStr.Equals(new string(charArray), StringComparison.OrdinalIgnoreCase);
    }
}