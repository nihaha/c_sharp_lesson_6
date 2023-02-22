using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Создайте программу, в которой создает метод, который в качестве аргументов принимает: 
 * 1) целочисленный массив(int [] array), 
 * 2) целочисленный индекс(int index), 
 * 3) количество элементов (int count), 
 * возвращает целочисленный массив элементов(int [] subArray). 
 * Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции 
 * указанной в аргументе index, размерностью, которая соответствует значению аргумента count.
 */
namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int index = 3;
            int count = 10;

            Console.WriteLine($"New array: [{String.Join(", ", Reshape(array, index, count))}]");
            Console.ReadLine();
        }

        static int[] Reshape(int[] array, int index, int count)
        {
            int[] subArray = new int[count];
            Array.Copy(array, index, subArray, 0, count);

            return subArray;
        }
    }
}
