using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prostokat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a szerokość prostokąta: ");
            uint a = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Podaj b wysokość prostokąta: ");
            uint b = Convert.ToUInt32(Console.ReadLine());

            for (int w = 0; w < b; w++) // w - numer wiersza, b wiersz
            {

                // pierwszy wiersz - a gwiazdek

                if (w==0)
                {
                    // jesteśmy w pierwszym wierszu
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                // pośrednie wiersze - 1 gwiazdka (a-2) spacje 1 gwiazdka
                if (w>0 && w<b-1)
                {
                    Console.Write("*");
                    for (int i = 0; i < a-2; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }

                // ostatni wiersz - a gwiazdek
                if (w==b-1)
                {
                    // gwiazdki w jednym wierszu - a gwiazdek - a kolumn
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                
            }

            Console.ReadKey();
        }
    }
}
