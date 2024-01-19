using System;

public class NEW
{
    static void Main()
    {
    int[] numbers = {10,11,12,13,14,15,16};
//Передача массива в функцию
    ReverseMassiv(numbers);
    static void ReverseMassiv(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
           Console.WriteLine(array[length -1 - i]);
        }
        
    }

        
}

}
        
