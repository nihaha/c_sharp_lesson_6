using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Создайте программу, в которой создайте массив размерностью в 5 элементов, выведите на экран 
 * все элементы массива в обратном порядке.
 */
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 11, 22, 33, 44, 55 };

            byte iter = 1;

            while (iter <= numbers.Length)
            {
                Console.WriteLine(numbers[numbers.Length - iter]);
                iter++;
            }

            Console.ReadLine();
        }
    }
}
