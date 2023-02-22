using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Создайте программу, в которой создайте массив размера N элементов (размер массива задет 
 * пользователь), заполнить его произвольными целыми значениями. Вывести на экран: 
 * наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов, 
 * среднее арифметическое всех элементов, вывести все нечетные значения.
 */
namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array size");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arraySize];

            Random rndNum = new Random();

            for (int i = 0; i < arraySize; i++) 
            {
                array[i] = rndNum.Next(0, 99999);
            }

            int max = array.Max();
            int min = array.Min();
            double avg = array.Average();
            int sum = array.Sum();

            Console.Write($"Max number is {array.Max()}\n");
            Console.Write($"Min number is {array.Min()}\n");
            Console.Write($"Average number is {array.Average()}\n");
            Console.Write($"Sum of all numbers {array.Sum()}\n");
            Console.Write("Odd numbers are:\n");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write(array[i] + " ");
                }                    
            }

            Console.ReadLine();
        }
    }
}
