using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, numP = 0, numO = 0;

            Console.WriteLine("Введите последовательность целых чисел:");
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 0) break;
                if (num > 0)
                {
                    numP++;
                }
                else { numO++; }

            } while (true);

            if (numP == numO)
            {
                Console.WriteLine($"Количество положительных ({numP}) и отрицательных ({numO}) чисел равное");

            }
            else if (numP > numO)
            {
                Console.WriteLine($"Количество положительных  чисел ({numP}) больше чем отрицательных  чисел ({numO})");
            }
            else { Console.WriteLine($"Количество отрицательных чисел ({numO}) больше чем положительных чисел {numP}"); }
            Console.ReadKey();

        }
    }
}
