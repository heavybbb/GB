/*������ 2
� ���������� �������� ����������� ����� N. �������� �� ����� �����
����� �� 1 �� N.*/

using System;
class Task2 {
  static void Main() {
    Console.WriteLine("������� ���� ");
    int N = Convert.ToInt32(Console.ReadLine());
    for (int N2=0,  i = 0; i <= N; i++)
    {
     
     N2  += i;
     
    if (N == i)
    {
     Console.Write($"{N2}, ");
    }
    }
    
  }
}