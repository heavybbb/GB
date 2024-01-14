/* Задача 1
С клавиатуры вводится натуральное число N. Выведите на экран все
делители числа N.*/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите чило ");
    double Number1 = Convert.ToInt32(Console.ReadLine());
    for (double Number2 =1 ,  i = 1; i <= Number1; i++)
    {
     
     Number2  = Number1 % i;
     
    if (Number2==0)
    {
     Console.Write($"{i}, ");
    }
    }
    
  }
}