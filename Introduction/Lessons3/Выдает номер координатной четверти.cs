using System;
class Program {
  static void Main() {
    Console.Write("Введите число x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x>0 && y>0)
        Console.Write($"1");
    else if (x>0 && y<0)
        Console.Write($"2");
    else if (x<0 && y<0)
        Console.Write($"3");
    else if (x<0 && y>0)
        Console.Write($"4");
   }
  }