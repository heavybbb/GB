/*
Medium
������ 1
���� ��� ��������� ����������� ����� M � N. ������� �� ����� ��
����� ��������.

*/

using System;
class Medium_Task1 {
  static void Main() {
    Console.WriteLine("������� ���� N ");
    double N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("������� ���� M ");
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
