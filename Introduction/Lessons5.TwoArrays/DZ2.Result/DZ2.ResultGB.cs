/* ������� ��������� ������. �������� ���������, ������� �������� ������� ������ � ��������� ������ �������.

��������� �������:

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 
���������:

9   10  11  12
5   6   7   8
1   2   3   4
*/

using System;

//���� ������ ����� �������� ���������. ����� ������ ����� ����������� ����� PrintResult()
class UserInputToCompileForTest
{
    // ������ �������
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

// ����� ������ � ��������� �������
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        for (int i = 0; i < array.GetLength(1); i++) {
            SwapItems(array, i);
        }
        return array;
    }

// ����� ���������� �������
    public static void SwapItems(int[,] array, int i)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }

    public static void PrintResult(int[,] numbers)
    {
        PrintArray(SwapFirstLastRows(numbers));
    }
}

//�� �������� � �� ������� ����� Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // ��������������, ��� ������ ��������� ������� � ��������, � �������� ������ ����� ��������� ��������
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // ���� ���������� �� ����� ���, ���������� ��������� ������
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            }; 
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}