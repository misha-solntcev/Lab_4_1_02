using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2. Сформировать массив из 10 целых чисел, выбранных случайным 
    образом из интервала [10, 50]. Найти максимальный среди 
    элементов с четными индексами. */

namespace Lab_4_1_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 50);
                if (i % 2 == 0 && array[i] > max)
                    max = array[i];
            }            
            Console.WriteLine(max);

            foreach (var item in array)            
                Console.Write(item + " ");
            Console.WriteLine("\n");

            // Linq
            var res = array.Where((x, i) => i % 2 == 0).Max();
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
