/* Строка с наименьшей суммой элементов
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
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

{
     int[,] array = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };
int sum2 =0;
int sum3=0;
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
      Console.Write(sum1[i] + "\t");
     
}
sum2=sum1.Min();
Console.WriteLine(sum2);

//Получаем индек числа в массиве
 int index = Array.IndexOf(sum1, sum2);
   Console.WriteLine(index);

//Пример подсчета всех чисел в массиве с помощью foreach
    foreach (int item in array)
        {
           sum3+=item;
        }
         Console.WriteLine(sum3);
    
}
