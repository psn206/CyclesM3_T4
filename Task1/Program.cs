using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Введите целое число N больше нуля");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rвадраты всех целых чисел от 1 до N:");
            for (int i = 1; i <= num; i++)
            {
                sum += i * 2 - 1;
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
    }
}
