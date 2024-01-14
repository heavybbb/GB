/*

Задача 5
С клавиатуры вводится натуральное число N. Выведите на экран
количество делителей числа N и их сумму.

*/

using System;
class Task5 {
  static void Main() {
    Console.WriteLine("Введите число N ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i =1;
    double N3 =1;
    double N2 = 0;
   
   for (;i<=N;i++)
    {
// ����� ����� N �� i � ���� ���������� ����� �����, �� ��� � ���� �������� ����� N 
      if (N % i == 0)
      {
// ������� � ������� ����� ������� ������ �������� N (%) ��� �������
       Console.WriteLine(i);
      }
   }
 }

}