/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Начальные условия:

// Начальные условия
int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};
Выводится: 1 */
using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
int i=0;
int j=0;
int k=array.GetLength(0);
int[] sum1= new int [k];
for ( i=0; i < array.GetLength(0);i++)
{
    for (j=0; j < array.GetLength(1);j++)
    {
     sum1[i]+=array[i,j];
    }
    //Проверка, печать суммы каждой строки
     /*  Console.Write(sum1[i] + "\t");
      Console.WriteLine(); */
  
}
return sum1;

}


// Получение индекса минимального элемента в одномерном массиве
  public static int MinIndex(int[] array)
    {
// Вычисление минимального числа в массиве
     int sum2=array.Min();
//Вычисление ИНДЕКСА минимального числа в массиве
      int index = Array.IndexOf(array, sum2);
      
      return index;
    }    
    
    public static void PrintResult(int[,] numbers)
    { 
   //Мы вызываем метод SumRows с передачей ему массива numbers. 
   //Этот метод вычисляет сумму каждой строки матрицы и возвращает массив, содержащий суммы.
   int[] rowSums = SumRows(numbers);

    // Выводим в консоль суммы каждой строки
    foreach (int sum in rowSums)
    {
        Console.Write(sum + "\t");
    }
    Console.WriteLine(); 

    // Передали в функцию MinIndex суммы каждой строки 
    // MinIndex нашла и возвратила индекс минимального числа в массиве.
    int minIndex = MinIndex(rowSums);
    Console.WriteLine($"{minIndex}");

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
            
            numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };      
        }
        UserInputToCompileForTest.PrintResult(numbers);
       // UserInputToCompileForTest.SumRows(numbers);
    }
}