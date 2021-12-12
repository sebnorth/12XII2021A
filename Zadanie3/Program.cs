using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                s += i;
                Console.WriteLine("Przebieg pętli numer: {0}", i);
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
