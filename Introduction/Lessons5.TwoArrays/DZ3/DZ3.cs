using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
int sum2 =0;
int sum3=0;
int i=0;
int j=0;
int k=array.GetLength(0);
int[] sum1= new int [k];
int[,] two_convert_array = new int[1, sum1.Length];
for ( i=0; i < array.GetLength(0);i++)
{
    for (j=0; j < array.GetLength(1);j++)
    {

          sum1[i]+=array[i,j];
          two_convert_array[0, i] = sum1[i];
          //Console.Write(two_convert_array[0,i] + "\t");
    }
      //Console.Write(sum1[i] + "\t");
      Console.WriteLine();
      Console.Write(two_convert_array[1,i] + "\t");
}
//MinIndex(two_convert_array);
return two_convert_array;

    }
// Получение индекса минимального элемента в одномерном массиве
    /* public static int MinIndex(int[] array)
    {
//SumRows();
      int sum2=array.Min();
      Console.WriteLine(sum2);
    }  */
    public static void PrintResult(int[,] numbers)
    {   
           
     // UserInputToCompileForTest.SumRows(numbers);
       //Напишите свое решение здесь
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            
            numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };      
        }
        UserInputToCompileForTest.PrintResult(numbers);
        UserInputToCompileForTest.SumRows(numbers);
    }
}