/* Задача 2: 
Задайте строку, содержащую латинские буквы в обоих регистрах.
Сформируйте строку, в которой все заглавные буквы заменены на строчные. */

using System;
using System.Globalization;

class Sample
{
        public static void Main()
    {
string str1= "qQqerRTYU ytyyu RERE ytut UIUIYY";
//Вывод и перевод строки в нижний регистр
    Console.Write(str1.ToLower());

    }
}
