// Задайте произвольную строку. Выясните, является ли она палиндромом.

using System;

namespace task_10
{
    class Program
    {
        public static bool Palindrome(string str)
        {
            str = str.ToLower();
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                    return false;
            }
            return true;
        }

        public static string InputString(string message)
        {
            bool inputError = true;
            string str = "";
            do
            {
                Console.Write(message);
                str = Console.ReadLine()!;
                if (str == "")
                    Console.WriteLine("Строка не может быть пустой");
                else
                    inputError = false;
            } while (inputError);

            return str;
        }

        static void Main()
        {
            Console.Clear();

            string str = InputString("Введите строку: ");

            if (Palindrome(str))
                Console.WriteLine($"Строка {str} является палиндромом");
            else
                Console.WriteLine($"Строка {str} не является палиндромом");
        }
    }
}