/* Задача 1: 
Задайте двумерный массив символов (тип char [,]). 
Создать строку из символов этого массива. */
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
            char[,] str = {
                            {'q','w','e'},
                            {'r','t','y'},
                            {'u','i','f'}
                            };
                            //Передаю в функцию symbols в массив str
                            char array1= symbols(str);
                            // Вывод в консоль строки из массива
                            Console.Write(array1);

//Функция которая принимает массив str, склеивает буквы в одну строку
        static char symbols(char[,] arraystr)
        {
        {
            char lastchar = '\0';
            foreach (char c in arraystr)
            {
                
                Console.Write(c   + "\t" );
                lastchar=c ;
            } 
            return lastchar;
        }
    }
}
}

       
    
