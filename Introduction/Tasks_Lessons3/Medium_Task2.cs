/*
Задача 2
Дано натуральное число N, которое является квадратом некоторого
числа (например, 25 или 36, или 625, или 961, …). Написать алгоритм, который
определяет, квадратом какого числа является число N. Операцию извлечения
квадратного корня и возведения в степень не использовать.
*/

using System;
class Medium_Task2 {
  static void Main() {
    Console.WriteLine("������� ���� N ");
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