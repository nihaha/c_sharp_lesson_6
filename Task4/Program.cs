using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Создайте программу, в которой создайте метод, который в качестве параметра принимает слово, 
 * а возвращает тоже слово, но с измененным порядком букв в слове на обратный.
 */
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a word");
            string word = Console.ReadLine();

            Console.WriteLine($"Inverted {word} is {ReverseWord(word)}");
            Console.ReadLine();
        }

        static string ReverseWord(string word) 
        {
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            return String.Join("", arr);
        }
    }
}
