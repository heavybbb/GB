/*

Задача 8
С клавиатуры вводится натуральное число N > 2. Вывести на экран
сумму квадратов натуральных чисел от 1 до N, которые больше чем среднее
геометрическое чисел 1,2,…,N.

*/

using System;
class Task8 {
  static void Main() {
    Console.WriteLine("Введите число N ");
    double N = Convert.ToInt32(Console.ReadLine());
    double i =1;
    double A =0; //Среднеарефметическое
    double G =0; //Среднегеометрическое
   
   for (;i<=N;i++)
    {
A = A+(i*i);
G =  Math.Sqrt(G*i);
if (A>G)
{
       Console.WriteLine(A);
}       
      }
   }
 }