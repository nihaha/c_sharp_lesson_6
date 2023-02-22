using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Создайте программу, в которой создайте два строковых массива с именами A и B (размерностью 
 * 4 элемента). Массив A заполняется в цикле пользователем. Получить результирующий массив B, 
 * обратный к исходному массиву A (элементы массива B идут в обратном порядке по отношению к массиву A).
 */
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] A = new string[4];
            string[] B = new string[4];
            byte iter = 0;

            while (A[A.Length - 1] == null) 
            {
                Console.WriteLine("Input string");
                A[iter] = Console.ReadLine();
                iter++;
            }

            B = A.Reverse().ToArray();

            Console.WriteLine("Array B has been reversed");
            Array.ForEach(B, Console.WriteLine);
            Console.ReadLine();
        }
    }
}
