/*������ 4
� ���������� �������� ����������� ����� N. �������� �� ����� �����
�� 1 �� N, ��� ������� ����� ���������: ??2 ������ v?? .

*/

using System;
class Task2 {
  static void Main() {
    Console.WriteLine("������� ���� ");
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