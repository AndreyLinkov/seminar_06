// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;

namespace task_09
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            string str = "My name is Andrey Suraev!";
            Console.WriteLine(str);
            string strLow = str.ToLower();
            Console.WriteLine(strLow);
        }
    }
}