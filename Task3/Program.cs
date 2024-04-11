using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чcла А,В,С,");
            Console.Write("А=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("C=");
            int c = Convert.ToInt32(Console.ReadLine());
            int numSquaers = 0, i = b - c;

          
            while (a >= c)
            {             
                a -= c;
                numSquaers++;
                while (i >= c)
                {
                    i -= c;
                    numSquaers++;
                   
                }
                i = b - c;
            }
            Console.WriteLine( $"Количество квадратов: {numSquaers}");
            Console.ReadKey();
        }
    }
}
