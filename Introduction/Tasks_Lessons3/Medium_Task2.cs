/*
Medium
«адача 2
ƒано натуральное число N, которое €вл€етс€ квадратом некоторого
числа (например, 25 или 36, или 625, или 961, Е). Ќаписать алгоритм, который
определ€ет, квадратом какого числа €вл€етс€ число N. ќперацию извлечени€
квадратного корн€ и возведени€ в степень не использовать.

*/

using System;
class Medium_Task1 {
  static void Main() {
    Console.WriteLine("¬ведите чило N ");
    int N = Convert.ToInt32(Console.ReadLine());
    int M = 0;
    int i =1;
    
    for (;i<N ;i++)
    {
      M = i*i;
      if (M==N)
      {
          Console.WriteLine(i);
      }
      
        }
      }
   
   }