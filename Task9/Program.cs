using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Создайте программу, в которой создайте массив целых чисел размерности 10х10 и заполните его 
 * случайными элементами. Выведете на консоль полученный массив. Найдите суммы элементов 
 * каждой строки, произведения элементов каждого столбца, и максимальный элемент главной 
 * диагонали (подсказка: все элементы, для которых номер строки совпадает с номером столбца).
 */
namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 99);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
