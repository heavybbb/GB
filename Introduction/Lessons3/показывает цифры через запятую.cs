using System;
class Program {
  static void Main() {
    Console.Write("Введите число : ");
    int Namber = Convert.ToInt32(Console.ReadLine());
    string NamberString = Namber.ToString();
    for (int i = 0; i < NamberString.Length; i++)
    {
    Console.Write($"{NamberString[i]},");
    }
   }
  }