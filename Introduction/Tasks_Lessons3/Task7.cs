/*

������ 7
� ���������� �������� ����������� ����� N > 5. ��������� ��������??/??
, ��� A � ������� �������������� ����� 1,2,�,N; G � ������� ��������������
����� 1,2,�,N.

*/

using System;
class Task5 {
  static void Main() {
    Console.WriteLine("������� ���� N ");
    double N = Convert.ToInt32(Console.ReadLine());
    double i =1;
    double A =0;
    double G =1;
    double Result=0;
   
   for (;i<=N;i++)
    {
// ������� �������������������� �����, �������� (1+2+3+4+5+6+7)/7
A = (A + i) / i;
//������� �������������������� �����
G =  Math.Sqrt(G*i);
Result = A / G;
       Console.WriteLine(Result);
       
      }
   }
 }