/*� ���������� �������� ����������� ����� N. �������� �� ����� �����
�� 1 �� N, ������ ���������� �� ������� ������ ����.
*/

using System;
class Task2 {
  static void Main() {
    Console.WriteLine("������� ���� ");
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