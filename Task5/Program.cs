using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
 * Создайте программу, в которой пользователь вводит прибыль фирмы за 12 месяцев. После чего 
 * пользователь вводит диапазон (например, 3 и 6 – поиск между 3-м и 6-м месяцем). Необходимо 
 * определить месяц, в котором прибыль была максимальна и месяц, в котором прибыль была 
 * минимальна с учетом выбранного диапазона.
 */
namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] profit = new double[12];
            byte iter = 0;

            while (profit[profit.Length - 1] == 0)
            {
                Console.WriteLine($"Input profit for {iter + 1} month");
                profit[iter] = Convert.ToDouble(Console.ReadLine());
                iter++;
            }

            Console.WriteLine("Input range start");
            int startMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input range end");
            int endMonth = Convert.ToInt32(Console.ReadLine());

            double[] range = new double[endMonth - startMonth + 1];

            Array.Copy(profit, startMonth - 1, range, 0, endMonth - startMonth + 1);
            Array.Sort(range);

            int maxProfit = Array.IndexOf(profit, range[range.Length - 1]) + 1;
            int minProfit = Array.IndexOf(profit, range[0]) + 1;

            Console.WriteLine($"Max profit was in {maxProfit} month");
            Console.WriteLine($"Min profit was in {minProfit} month");
            Console.ReadLine();
        }
    }
}
