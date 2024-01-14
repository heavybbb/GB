/*
Задача 2
С клавиатуры вводится натуральное число N. Выведите на экран сумму
чисел от 1 до N.
*/

using System;
class Task2 {
  static void Main() {
    Console.WriteLine("Введите чило N ");
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