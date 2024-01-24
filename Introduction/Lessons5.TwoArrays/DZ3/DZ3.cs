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
int i=0;
int k=array.GetLength(0);
int[] sum1= new int [k];
for ( i=0; i < array.GetLength(0);i++)
{
    for (int j=0; j < array.GetLength(1);j++)
    {
       sum1[i]+=array[i,j];
    }
      Console.Write(sum1[i] + "\t");
}
    for (i=0;i<sum1.GetLength(0);i++)
    {
        if (sum1[i]<sum1[i+1])
        {
            sum2= sum1[i];
        }
        
        else {
            sum2=sum1[i+1];
            }
    }
    
}
