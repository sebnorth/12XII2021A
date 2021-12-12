using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0; 
            int b = 0;


                Console.WriteLine("Podaj a: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Podaj b: ");
                b = Convert.ToInt32(Console.ReadLine());

            // zamiana ról a i b o ile a>b

            //if (a>b)
            //{
            //    int kopia = b;
            //    b = a;
            //    a = kopia; 
            //}

            if (a>b)
            {
                (a, b) = (b, a);
            }

            int liczba = a;

            while (liczba<=b)
            {
                if (liczba%2 == 0)
                {
                    Console.Write("{0} ", liczba);
                }

                liczba++;
            }

            Console.ReadKey();
        }
    }
}
