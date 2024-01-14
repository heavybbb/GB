/*Задача 4
С клавиатуры вводится натуральное число N. Выведите на экран числа
от 1 до N, для которых верно следующее: ??2 кратно v?? .

*/

using System;
class Task2 {
  static void Main() {
    Console.WriteLine("Введите чило ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i =1;
    double N3 =1;
    double N2 = 0;
   
   for (;i<=N;i++)
    {
      N2 = Math.Sqrt(i);
      N3 = i*i;
      if (N3 % N2 == 0)
      {
       Console.WriteLine(i);
      }
   }
 }

}