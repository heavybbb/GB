/*

Задача 5
С клавиатуры вводится натуральное число N. Выведите на экран
количество делителей числа N и их сумму

*/

using System;
class Task5 {
  static void Main() {
    Console.WriteLine("Введите чило N ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i =1;
    double N3 =1;
    double N2 = 0;
   
   for (;i<=N;i++)
    {
// Делим число N на i и если получилось целое число, то это и есть делитель числа N 
      if (N % i == 0)
      {
// Выводим в консоль число которое смогло поделить N (%) без остатка
       Console.WriteLine(i);
      }
   }
 }

}