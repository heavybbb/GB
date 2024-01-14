using System;
class Program {
  static void Main() {
Console.WriteLine("Введите число");
int Namber = Convert.ToInt32(Console.ReadLine());
int Namber1 = Namber / 10 ;
int Namber2 = Namber % 10;
if ( Namber > 10 && Namber < 99 && Namber1 > Namber2)
{
Console.WriteLine(Namber1);
}
else if ( Namber > 10 && Namber < 99 && Namber1 < Namber2)
{
Console.WriteLine(Namber2); 
}}}