using System;
class ProgramNamber {
  static void Main() {
    int a =7;
    int b= 23;
    Console.Write("Введите число: ");
    double Namber = Convert.ToInt32(Console.ReadLine());
    double Namber4 = Namber % a;
    double Namber5 = Namber % b;
if (Namber4 == 0 && Namber5 == 0)
{
        Console.Write($"Введенное число {Namber} является кратным 7 и 23.");
}    
else
   {
       Console.Write($"Введенное число {Namber} не является кратным 7 и 23.");
   }
   }
  }