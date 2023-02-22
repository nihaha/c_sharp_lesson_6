using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Создайте программу, в которой создайте метод, который будет выполнять увеличение длины 
 * массива переданного в качестве аргумента, на 1 элемент. Метод, должен принимает два 
 * аргумента, первый аргумент - типа int[] array, второй аргумент - типа int value. В теле 
 * метода реализуйте возможность добавления второго аргумента метода в массив по индексу – 0, 
 * при этом длина нового массива, должна увеличиться на 1 элемент, а элементы получаемого 
 * массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса - 1.
 */
namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            int value = 99;
                        
            Console.WriteLine($"New array: [{String.Join(", ", ExtendArray(array, value))}]");
            Console.ReadLine();
        }

        static int[] ExtendArray(int[] array, int value)
        {
            int[] subArray = new int[array.Length + 1];
            subArray[0] = value;
            Array.Copy(array, 0, subArray, 1, array.Length);

            return subArray;
        }
    }
}
