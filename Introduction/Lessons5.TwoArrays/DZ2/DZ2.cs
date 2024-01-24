/* Задайте двумерный массив. Напишите программу, которая поменяет местами 
первую и последнюю строку массива.

Начальные условия:

int[,] numbers = new int[,] {
{1, 2, 3, 4},
{5, 6, 7, 8},
{9, 10, 11, 12}
}; 
Выводится:

9   10  11  12
5   6   7   8
1   2   3   4 */

using System;
using System.Globalization;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters;
//using System.Threading.Tasks.Dataflow;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
// Печать массива
public static void PrintArray(int[,] array)
{
    for (int j=0;j< array.GetLength(0);j++)
        {
            for (int i=0;i < array.GetLength(1);i++)    
                {
                    //Console.Write(array[j,i] + "\t");
                }
                    //Console.WriteLine();
        }
    //return ; 
} 
// Обмен первой с последней строкой
public static int[,] SwapFirstLastRows(int[,] array)
{       
    int k= array.GetLength(0)-1; //Последняя строка массива
    //
        for (int j=0,i=0; j<array.GetLength(1) ;j++) 
            {
                int temparray = array[i,j];
                array[i,j]=array[k,j];
                array[k,j]=temparray;
            }
       PrintArray(array);
       PrintResult(array);
    return array;
}
// Обмен элементами массива
public static void SwapItems(int[,] array, int i)
{
//Напишите свое решение здесь
}
public static void PrintResult(int[,] numbers)
{
    for (int j=0;j< numbers.GetLength(0);j++)
        {
            for (int i=0;i < numbers.GetLength(1);i++)
                {
                    Console.Write(numbers[j,i] + "\t");
                }
                    Console.WriteLine();
        }
}
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
public static void Main(string[] args)
{
int[,] numbers;

if (args.Length >= 1)
{
// Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
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
// Если аргументов на входе нет, используем примерный массив
numbers = new int[,]
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 
// Console.WriteLine(numbers);
/*  }
UserInputToCompileForTest.PrintResult(numbers);
*/
// UserInputToCompileForTest.PrintArray(numbers);

UserInputToCompileForTest.SwapFirstLastRows(numbers);
}
}   
}