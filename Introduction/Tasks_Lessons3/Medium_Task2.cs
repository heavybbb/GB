/*
Medium
������ 2
���� ����������� ����� N, ������� �������� ��������� ����������
����� (��������, 25 ��� 36, ��� 625, ��� 961, �). �������� ��������, �������
����������, ��������� ������ ����� �������� ����� N. �������� ����������
����������� ����� � ���������� � ������� �� ������������.

*/

using System;
class Medium_Task1 {
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