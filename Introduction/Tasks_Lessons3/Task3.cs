/*С клавиатуры вводится натуральное число N. Выведите на экран числа
от 1 до N, корень квадратный из которых кратен пяти.
*/

using System;
class Task2 {
  static void Main() {
    Console.WriteLine("Введите чило ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i =1;
    double N2 = 0;
   
   for (;i<=N;i++)
    {
      N2 = Math.Sqrt(i);
      if (N2 % 5==0)
      {
       Console.WriteLine(i);
      }
   }
 }

}