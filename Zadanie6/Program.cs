using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n długość boku kwadratu: ");
            uint n = Convert.ToUInt32(Console.ReadLine());

            for (int w = 0; w < n; w++) // w - numer wiersza
            {
                // gwiazdki w jednym wierszu - n gwiazdek - n kolumn
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }

            Console.ReadKey();
        }
    }
}
