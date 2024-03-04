// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

using System;

namespace task_08
{
    class Program
    {
        public static string StringArray(char[,] array)
        {
            string str = "";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    str += array[i, j].ToString();
                }
            }
            return str;
        }

        public static void PrintArray(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void FillArray(char[,] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = (char)random.Next('a', 'z');
                }
            }
        }

        static void Main()
        {
            Console.Clear();

            char[,] array = new char[6, 6];
            FillArray(array);
            PrintArray(array);
            string str = StringArray(array);
            Console.WriteLine(str);
        }
    }
}
