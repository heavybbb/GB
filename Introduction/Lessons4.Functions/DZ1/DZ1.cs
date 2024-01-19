using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для выхода:");
            string input = Console.ReadLine();

            if (input == "q")
            {
                break;
            }

            if (TryProcessInput(input, out int number))
            {
                if (IsEvenDigitSum(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для выхода.");
            }
        }
    }

    static bool TryProcessInput(string input, out int number)
    {
        return int.TryParse(input, out number);
    }

    static bool IsEvenDigitSum(int number)
    {
        int sum = 0;
        int tempNumber = number;

        // Рассчитываем сумму цифр числа
        while (tempNumber != 0)
        {
            sum += tempNumber % 10;
            tempNumber /= 10;
        }

        // Проверяем, является ли сумма четной
        return sum % 2 == 0;
    }
}