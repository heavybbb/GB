/*
Medium
Задача 1
Даны два различных натуральных числа M и N. Вывести на экран их
общие делители.

*/

using System;
class Medium_Task1 {
  static void Main() {
    Console.WriteLine("Введите чило N ");
    double N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите чило M ");
    double M = Convert.ToInt32(Console.ReadLine());
    double i =1;
    double common_divisor = 0;
   
   
   
 
   for (;N>=M && i<=M ;i++)
    {
       if ( N % i ==0 &&  M % i ==0)
        {
          common_divisor = i ;
        
            Console.WriteLine(common_divisor);
        }
      }
    for (;N<M && i<N ;i++)
    {
       if ( M % i ==0 && N % i ==0 )
        {
          common_divisor = i ;
        
            Console.WriteLine(common_divisor);
        }
      }
   }
 }
