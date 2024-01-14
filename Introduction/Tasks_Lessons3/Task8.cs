/*

С клавиатуры вводится натуральное число N > 2. Вывести на экран
сумму квадратов натуральных чисел от 1 до N, которые больше чем среднее
геометрическое чисел 1,2,…,N.

*/

using System;
class Task8 {
  static void Main() {
    Console.WriteLine("Введите чило N ");
    double N = Convert.ToInt32(Console.ReadLine());
    double i =1;
    double A =0;
    double G =1;
    double Result=0;
   
   for (;i<=N;i++)
    {
// Находим сумму квадратов, например (1+2+3+4+5+6+7)/7
A = A+(i*i);
//Находим среднегеометрическое число
G =  Math.Sqrt(G*i);
if (A>G)
{
       Console.WriteLine(A);
}
else  Console.WriteLine(G);
       
      }
   }
 }