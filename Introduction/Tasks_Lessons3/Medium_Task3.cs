/*******
С клавиатуры вводится натуральное число N. Выведите на экран
простые числа от 100 до N, которые состоят не менее чем из трех цифр.
Использовать арифметику для определения кол-ва цифр в числе.  123
*/
internal class Program
{
    private static void Main(string[] args)
    {   Console.WriteLine("Введите число");
       
        double Number = Convert.ToInt32(Console.ReadLine());
        double i =1;

     for (;Number>100 && i<Number;i++)  //число должно быть больше 100 и больше счетчика "i"
            {
                if (Number % i ==0 && i > 100) // если остаток числа = 0 и делитель больше ста, то-
                     {
                         Console.WriteLine(i);
                     } 
             }
     }
}